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
        private readonly ILoggerManager _logger;
        private readonly Context _Context;
        public CPUController(ILoggerManager logger, Context Context)
        {
            _logger = logger;
            _Context = Context;
        }

        // GET api/cpu
        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInfo("Querying all CPUs!");
            return Ok(_Context.CPUs.Include(c => c.Socket).Include(c => c.Manufacturer).Include(c => c.CPUDetail).Include(c => c.Chipset).ToList());
        }

        // GET api/cpu/{id}
        [HttpGet("{id}")]
        public IActionResult GetCPUByID(int id)
        {
            _logger.LogInfo($"Querying for the CPU with the id: {id}");
            return Ok(_Context.CPUs.Where(c => c.CPUId == id).AsNoTracking().Include(c => c.Socket).Include(c => c.Manufacturer).Include(c => c.CPUDetail).Include(c => c.Chipset).FirstOrDefault());
        }

        // GET api/cpu/Manufacturer
        [HttpGet("Manufacturer")]
        public IActionResult GetManufacturer()
        {
            try
            {
                _logger.LogInfo("Querying all Manufacturers!");
                var test = _Context.Manufacturers.Include(a => a.CPUs).ToList();
                foreach(var i in test)
                {
                    Console.WriteLine(i.ManufacturerId);
                    Console.WriteLine(i.Name);
                    foreach(var t in i.CPUs)
                    {
                        Console.WriteLine(t.CPUId);
                        Console.WriteLine(t.Name);
                    }
                }
                return Ok(test);
            }
            catch(Exception ex)
            {
                _logger.LogError($"Something went wrong inside of Controller: CPU. Action: GetManufacturer. With the error message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }
    }
}
