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
    public class ChipsetController : ControllerBase
    {
        private readonly ILoggerManager _Logger;
        private readonly Context _Context;
        public ChipsetController(ILoggerManager Logger, Context Context)
        {
            _Logger = Logger;
            _Context = Context;
        }

        // GET api/Chipset
        [HttpGet]
        public IActionResult GetChipsets()
        {
            try
            {
                _Logger.LogInfo("Querying all Chipsets!");
                return Ok(_Context.Chipsets.Include(a => a.CPUs).ToList());
            }
            catch(Exception ex)
            {
                _Logger.LogError($"Something went wrong inside of Controller: Chipset. Action: GetChipsets. With the error message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/Chipset/id
        [HttpGet("{id}")]
        public IActionResult GetChipsetId(int id)
        {
            try
            {
                _Logger.LogInfo($"Querying Chipset with the id: {id}");
                return Ok(_Context.Chipsets.Include(m => m.CPUs).FirstOrDefault(m => m.ChipsetId == id));
            }
            catch(Exception ex)
            {
                _Logger.LogError($"Something went wrong inside of Controller: Chipset. Action: GetChipsetId. With the error message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }
    }
}
