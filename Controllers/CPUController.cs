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
        private readonly ICPURepository _ICPURepository;
        public CPUController(ILoggerManager Logger, ICPURepository ICPURepository)
        {
            _Logger = Logger;
            _ICPURepository = ICPURepository;
        }

        // GET api/cpu
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                _Logger.LogInfo(ControllerContext, $"Querying all CPUs!");
                return Ok(await _ICPURepository.GetAllCPUsAsync());
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/cpu/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCPUByID(int id)
        {
            try
            {
                _Logger.LogInfo(ControllerContext, $"Querying CPU with the id: {id}");
                return Ok(await _ICPURepository.GetCPUByIDAsync(id));
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/cpu/{name}
        [HttpGet("name/{name}")]
        public async Task<IActionResult> GetCPUByName(string Name)
        {
            try
            {
                _Logger.LogInfo(ControllerContext, $"Querying for the CPU with the name: {Name}");
                return Ok(await _ICPURepository.GetCPUByNameAsync(Name));
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }
    }
}
