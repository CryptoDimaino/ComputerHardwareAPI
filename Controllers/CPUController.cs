using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComputerHardware.Contracts;
using ComputerHardware.Models;
using Microsoft.EntityFrameworkCore;

namespace ComputerHardware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CPUController : ControllerBase
    {
        private readonly ILoggerManager _Logger;
        private readonly Context _Context;
        private readonly ICPURepository _ICPURepository;
        public CPUController(ILoggerManager Logger, Context Context, ICPURepository ICPURepository)
        {
            _Logger = Logger;
            _Context = Context;
            _ICPURepository = ICPURepository;
        }

        // GET api/cpu
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                _Logger.LogInfo("Querying all CPUs!");
                return Ok(await _ICPURepository.GetAllCPUsAsync());
                //return Ok(_Context.CPUs.Include(c => c.Socket).Include(c => c.Manufacturer).Include(c => c.CPUDetail).Include(c => c.Chipset).ToList());
            }
            catch(Exception ex)
            {
                _Logger.LogError($"Something went wrong inside of Controller: CPU. Action: Get. With the error message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/cpu/{id}
        [HttpGet("{id}")]
        public IActionResult GetCPUByID(int id)
        {
            try
            {
                _Logger.LogInfo($"Querying for the CPU with the id: {id}");
                return Ok(_Context.CPUs.Where(c => c.CPUId == id).AsNoTracking().Include(c => c.Socket).Include(c => c.Manufacturer).Include(c => c.CPUDetail).Include(c => c.Chipset).FirstOrDefault());
            }
            catch(Exception ex)
            {
                _Logger.LogError($"Something went wrong inside of Controller: CPU. Action: GetCPUByID. With the error message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/cpu/{name}
        [HttpGet("name/{name}")]
        public IActionResult GetCPUByName(string Name)
        {
            try
            {
                _Logger.LogInfo($"Querying for the CPU with the name: {Name}");
                return Ok(_Context.CPUs.Where(c => c.Name == Name).AsNoTracking().Include(c => c.Socket).Include(c => c.Manufacturer).Include(c => c.CPUDetail).Include(c => c.Chipset).FirstOrDefault());
            }
            catch(Exception ex)
            {
                _Logger.LogError($"Something went wrong inside of Controller: CPU. Action: GetCPUByID. With the error message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }
    }
}
