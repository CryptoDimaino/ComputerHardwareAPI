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
    public class ManufacturerController : ControllerBase
    {
        private readonly ILoggerManager _Logger;
        private readonly Context _Context;
        public ManufacturerController(ILoggerManager Logger, Context Context)
        {
            _Logger = Logger;
            _Context = Context;
        }

        // GET api/Manufacturer
        [HttpGet]
        public IActionResult GetManufacturers()
        {
            try
            {
                _Logger.LogInfo("Querying all Manufacturers!");
                return Ok(_Context.Manufacturers.Include(a => a.CPUs).ToList());
            }
            catch(Exception ex)
            {
                _Logger.LogError($"Something went wrong inside of Controller: Manufacturer. Action: GetManufacturers. With the error message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/Manufacturer/id
        [HttpGet("{id}")]
        public IActionResult GetManufacturerId(int id)
        {
            try
            {
                _Logger.LogInfo($"Querying Manufacturer with the id: {id}");
                return Ok(_Context.Manufacturers.Include(m => m.CPUs).ThenInclude(c => c.Socket).Include(m => m.CPUs).ThenInclude(c => c.CPUDetail).Include(m => m.CPUs).ThenInclude(c => c.Chipset).FirstOrDefault(m => m.ManufacturerId == id));
            }
            catch(Exception ex)
            {
                _Logger.LogError($"Something went wrong inside of Controller: Manufacturer. Action: GetManufacturerId. With the error message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }
    }
}
