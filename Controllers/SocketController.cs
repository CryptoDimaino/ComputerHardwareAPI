using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComputerHardware.Contracts;
using ComputerHardware.Models;
using Microsoft.EntityFrameworkCore;
using ComputerHardware.Repositories;
using ComputerHardware.Helpers;

namespace ComputerHardware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocketController : ControllerBase
    {
        private readonly ILoggerManager _Logger;
        private readonly ISocketRepository _ISocketRepository;
        public SocketController(ILoggerManager Logger, ISocketRepository ISocketRepository)
        {
            _Logger = Logger;
            _ISocketRepository = ISocketRepository;
        }

        // GET api/socket
        [HttpGet]
        public async Task<IActionResult> GetSockets()
        {
            try
            {
                _Logger.LogDebug(ControllerContext, $"Querying all Sockets!");
                return Ok(await _ISocketRepository.GetAllSocketsAsync());
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/socket/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSocketId(int id)
        {
            try
            {
                _Logger.LogInfo(ControllerContext, $"Querying Socket with the id: {id}");
                return Ok(await _ISocketRepository.GetSocketByIDAsync(id));
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // POST api/socket
        [HttpPost("CreateNewSocket")]
        public async Task<IActionResult> CreateNewSocket()
        {
            int SocketCountPlus1 = await _ISocketRepository.CountNumberOfSocketsAsync() + 1;
            Socket NewSocket = new Socket()
            {
                Name = $"SocketName{SocketCountPlus1}",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            try
            {
                await _ISocketRepository.CreateSocketAsync(NewSocket);
                _Logger.LogInfo(ControllerContext, $"Name: {NewSocket.Name}");
                return NoContent();
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // PUT api/socket/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSocket(int id)
        {
            try
            {
                Socket SocketToUpdate = await _ISocketRepository.GetSocketByIDAsync(id);
                if(SocketToUpdate == null)
                {
                    _Logger.LogError(ControllerContext, $"Error Message: Socket with the id: {id} is not in the database.");
                    return StatusCode(500, "Internal Server Error.");
                }
                _Logger.LogInfo(ControllerContext, $"Socket with the id: {id} has been updated.");
                
                SocketToUpdate.UpdatedAt = DateTime.Now;
                await _ISocketRepository.UpdateSocketAsync(SocketToUpdate);
                return NoContent();
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // DELETE api/socket/delete/id
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteSocket(int id)
        {
            _Logger.LogWarn(ControllerContext, $"Deleting a socket will delete all CPU information under it and also delete all cpudetails.");
            try
            {
                Socket SocketToDelete = await _ISocketRepository.GetSocketByIDAsync(id);
                if(SocketToDelete == null)
                {
                    _Logger.LogError(ControllerContext, $"Socket with id: {id}, hasn't been found in database.");
                    return NotFound();
                }
                _Logger.LogInfo(ControllerContext, $"Socket with id: {id} has been deleted.");
                await _ISocketRepository.DeleteSocketAsync(SocketToDelete);
                return NoContent();
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/socket/count
        [HttpGet("count")]
        public async Task<IActionResult> GetNumberOfSockets()
        {
            try
            {
                int NumOfSockets = await _ISocketRepository.CountNumberOfSocketsAsync();
                _Logger.LogInfo(ControllerContext, $"There are {NumOfSockets} chipsets!");
                return Ok(NumOfSockets);
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }
    }
}
