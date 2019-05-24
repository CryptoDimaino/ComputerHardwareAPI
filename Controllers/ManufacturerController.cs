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
        private readonly IManufacturerRepository _IManufacturerRepository;
        public ManufacturerController(ILoggerManager Logger, IManufacturerRepository IManufacturerRepository)
        {
            _Logger = Logger;
            _IManufacturerRepository = IManufacturerRepository;
        }

        // GET api/Manufacturer
        [HttpGet]
        public async Task<IActionResult> GetManufacturers()
        {
            try
            {
                _Logger.LogInfo(ControllerContext, $"Querying all Manufacturers!");
                return Ok(await _IManufacturerRepository.GetAllManufacturersAsync());
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/manufacturer/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetManufacturerId(int id)
        {
            try
            {
                _Logger.LogInfo(ControllerContext, $"Querying Manufacturer with the id: {id}");
                return Ok(await _IManufacturerRepository.GetManufacturerByIDAsync(id));
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/manufacturer/{name}
        [HttpGet("name/{name}")]
        public async Task<IActionResult> GetManufacturerByName(string Name)
        {
            try
            {
                _Logger.LogInfo(ControllerContext, $"Querying for the Manufacturer with the name: {Name}");
                return Ok(await _IManufacturerRepository.GetManufacturerByNameAsync(Name));
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // POST api/manufacturer/createnewmanufacturer
        [HttpPost("createnewmanufacturer")]
        public async Task<IActionResult> CreateNewManufacturer()
        {
            Manufacturer NewManufacturer = new Manufacturer() 
            {
                Name = "Something",
                URL ="Som URL",
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };

            try
            {
                await _IManufacturerRepository.CreateManufacturerAsync(NewManufacturer);
                _Logger.LogInfo(ControllerContext, $"Name: {NewManufacturer.Name}");
                return NoContent();
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }    


        // PUT api/manufacturer/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateManufacturer(int id)
        {
            try
            {
                Manufacturer ManufacturerToUpdate = await _IManufacturerRepository.GetManufacturerByIDAsync(id);
                if(ManufacturerToUpdate == null)
                {
                    _Logger.LogError(ControllerContext, $"Error Message: Manufacturer with the id: {id} is not in the database.");
                    return StatusCode(500, "Internal Server Error.");
                }
                _Logger.LogInfo(ControllerContext, $"Manufacturer with the id: {id} has been updated.");
                
                ManufacturerToUpdate.UpdatedAt = DateTime.Now;
                await _IManufacturerRepository.UpdateManufacturerAsync(ManufacturerToUpdate);
                return NoContent();
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }   

        // DELETE api/manufacturer/delete/{id}
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteManufacturer(int id)
        {
            _Logger.LogWarn(ControllerContext, $"Deleting a Manufacturer will delete the all cpus and cpudetails linked to the manufacturer.");
            try
            {
                Manufacturer ManufacturerToDelete = await _IManufacturerRepository.GetManufacturerByIDAsync(id);
                if(ManufacturerToDelete == null)
                {
                    _Logger.LogError(ControllerContext, $"Manufacturer with the id {id} hasn't been found in the database.");
                    return NotFound();
                }
                _Logger.LogInfo(ControllerContext, $"CPU with the id: {id} has been deleted.");
                await _IManufacturerRepository.DeleteManufacturerAsync(ManufacturerToDelete);
                return NoContent();
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }   

        // GET api/manufacturer/count
        [HttpGet("count")]
        public async Task<IActionResult> GetNumberOfManufacturers()
        {
            try
            {
                int NumOfManufacturers = await _IManufacturerRepository.CountNumberOfManufacturersAsync();
                _Logger.LogInfo(ControllerContext, $"There are {NumOfManufacturers} cpus!");
                return Ok(NumOfManufacturers);
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }  
    }
}
