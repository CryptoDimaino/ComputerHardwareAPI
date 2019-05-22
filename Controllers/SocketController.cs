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
    public class SocketController : ControllerBase
    {
        private readonly ILoggerManager _Logger;
        private readonly Context _Context;
        public SocketController(ILoggerManager Logger, Context Context)
        {
            _Logger = Logger;
            _Context = Context;
        }

        // GET api/Socket
        [HttpGet]
        public IActionResult GetSockets()
        {
            try
            {
                _Logger.LogInfo("Querying all Sockets!");
                return Ok(_Context.Sockets.Include(a => a.CPUs).ToList());
            }
            catch(Exception ex)
            {
                _Logger.LogError($"Something went wrong inside of Controller: Socket. Action: GetSockets. With the error message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/Socket/id
        [HttpGet("{id}")]
        public IActionResult GetSocketId(int id)
        {
            try
            {
                _Logger.LogInfo($"Querying Socket with the id: {id}");
                return Ok(_Context.Sockets.Include(m => m.CPUs).FirstOrDefault(m => m.SocketId == id));
            }
            catch(Exception ex)
            {
                _Logger.LogError($"Something went wrong inside of Controller: Manufacturer. Action: GetManufacturerId. With the error message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }
    }
}
