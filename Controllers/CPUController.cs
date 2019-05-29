using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComputerHardware.Contracts;
using ComputerHardware.Models;
using Microsoft.EntityFrameworkCore;
using ComputerHardware.DTOs;

namespace ComputerHardware.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CPUController : ControllerBase
    {
        private readonly ILoggerManager _Logger;
        private readonly ICPURepository _ICPURepository;
        private readonly Context _Context;
        public CPUController(ILoggerManager Logger, ICPURepository ICPURepository, Context Context)
        {
            _Logger = Logger;
            _ICPURepository = ICPURepository;
            _Context = Context;
        }

        // TEST
        [HttpGet("test")]
        public async Task<IActionResult> Test()
        {
            return Ok(await _ICPURepository.GetAllCPUDTOsAsync());;
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

        // POST api/cpu/createnewcpu
        [HttpPost("CreateNewCPU")]
        public async Task<IActionResult> CreateNewCPU()
        {
            int CPUCountPlus1 = await _ICPURepository.CountNumberOfCPUsAsync() + 1;
            CPU NewCPU = new CPU() 
                {
                    Name = $"giberish{CPUCountPlus1}",
                    CoreCount = 8,
                    ThreadCount = 16,
                    BaseFrequency = 3.60,
                    MaxFrequency = 5.00,
                    L3Cache = 16,
                    TDP = 95,
                    Series = "Intel Core i9",
                    Family = "Coffee Lake",
                    Type = "Desktop",
                    ECC = false,
                    SMT = true,
                    Lithography = "14",
                    MaxMemory = "128",
                    MaxMemoryChannel = "2",
                    IntegratedGraphics = "",
                    MaxGPUClockRate = "",
                    MSRPPrice = 500.00,
                    PCIExpressLanes = 16,
                    ReleaseDate = "Q4'18",
                    SocketId = 2,
                    ManufacturerId = 1,
                    ChipsetId = 1,
                    CreatedAt = DateTime.Now, 
                    UpdatedAt = DateTime.Now
                };

            try
            {
                await _ICPURepository.CreateCPUAsync(NewCPU);
                _Logger.LogInfo(ControllerContext, $"Name: {NewCPU.Name}");
                return NoContent();
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }    


        // PUT api/cpu/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCPU(int id)
        {
            try
            {
                CPU CPUToUpdate = await _ICPURepository.GetCPUByIDAsync(id);
                if(CPUToUpdate == null)
                {
                    _Logger.LogError(ControllerContext, $"Error Message: CPU with the id: {id} is not in the database.");
                    return StatusCode(500, "Internal Server Error.");
                }
                _Logger.LogInfo(ControllerContext, $"CPU with the id: {id} has been updated.");
                
                CPUToUpdate.UpdatedAt = DateTime.Now;
                await _ICPURepository.UpdateCPUAsync(CPUToUpdate);
                return NoContent();
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }   

        // DELETE api/cpu/delete/{id}
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteCPU(int id)
        {
            _Logger.LogWarn(ControllerContext, $"Deleting a cpu will also delete the cpudetails.");
            try
            {
                CPU CPUToDelete = await _ICPURepository.GetCPUByIDAsync(id);
                if(CPUToDelete == null)
                {
                    _Logger.LogError(ControllerContext, $"Chipset with the id {id} hasn't been found in the database.");
                    return NotFound();
                }
                _Logger.LogInfo(ControllerContext, $"CPU with the id: {id} has been deleted.");
                await _ICPURepository.DeleteCPUAsync(CPUToDelete);
                return NoContent();
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }   

        // GET api/cpu/count
        [HttpGet("count")]
        public async Task<IActionResult> GetNumberOfCPUs()
        {
            try
            {
                int NumOfCPUs = await _ICPURepository.CountNumberOfCPUsAsync();
                _Logger.LogInfo(ControllerContext, $"There are {NumOfCPUs} cpus!");
                return Ok(NumOfCPUs);
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }  


        // GET api/cpu/DTO
        // [HttpGet("DTO")]
        // public async Task<IActionResult> GetDTO()
        // {
        //     try
        //     {

        //         _Logger.LogInfo(ControllerContext, $"Querying all CPUs!");
        //         return Ok(await _ICPURepository.GetAllCPUDTOsAsync());
        //     }
        //     catch(Exception ex)
        //     {
        //         _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
        //         return StatusCode(500, "Internal Server Error.");
        //     }
        // }
    }
}
