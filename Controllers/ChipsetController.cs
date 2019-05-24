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
    public class ChipsetController : ControllerBase
    {
        private readonly ILoggerManager _Logger;
        private readonly IChipsetRepository _IChipsetRepository;

        
        public ChipsetController(ILoggerManager Logger, IChipsetRepository IChipsetRepository)
        {
            _Logger = Logger;
            _IChipsetRepository = IChipsetRepository;
        }

        // GET api/Chipset
        [HttpGet]
        public async Task<IActionResult> GetChipsets()
        {
            try
            {
                _Logger.LogInfo(ControllerContext, $"Querying all Chipsets!");
                return Ok(await _IChipsetRepository.GetAllChipsetsAsync());
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/Chipset/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetChipsetId(int id)
        {
            try
            {
                _Logger.LogInfo(ControllerContext, $"Querying Chipset with the id: {id}");
                return Ok(await _IChipsetRepository.GetChipsetByIDAsync(id));
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/chipset/{name}
        [HttpGet("name/{name}")]
        public async Task<IActionResult> GetChipsetByName(string Name)
        {
            try
            {
                _Logger.LogInfo(ControllerContext, $"Querying for the Chipset with the name: {Name}");
                return Ok(await _IChipsetRepository.GetChipsetByNameAsync(Name));
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }


        // POST api/Chipset/CreateNewChipset
        [HttpPost("CreateNewChipset")]
        public async Task<IActionResult> CreateNewChipset()
        {
            int ChipsetCountPlus1 = await _IChipsetRepository.CountNumberOfChipsetsAsync() + 2;
            Chipset NewChipset = new Chipset()
                {
                    ChipsetId = ChipsetCountPlus1,
                    Name = $"SomeChipset{ChipsetCountPlus1}",
                    LaunchDate = "Q2'17",
                    BusSpeed = "TBD",
                    TDP = "TBD",
                    Overclock = true,
                    DIMMsPerChannel = "4",
                    DisplaysSupported = "0",
                    PCIExpressRevision = "3.0",
                    MaxPCIExpressLanes = "8",
                    NumberOfUSBPorts = 14,
                    USBRevision = "3.1",
                    MaxSata3Ports = 12,
                    IntelOptaneMemorySupported = null,
                    IntelvProPlatformEligibility = null,
                    IntelMEFirmwareVersion = null,
                    IntelHDAudioTechnology = null,
                    IntelRapidStorageTechnology = null,
                    IntelRapidStorageTechnologyForPCIStorage = null,
                    IntelSmartSoundTechnology = null,
                    IntelPlatformTTTrustTechnology = null,
                    IntelBootGuard = null
                };
            try
            {
                _Logger.LogInfo(ControllerContext, $"Name: {NewChipset.Name}");
                await _IChipsetRepository.CreateChipsetAsync(NewChipset);
                return NoContent();
            }   
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // PUT api/chipset/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateChipset(int id)
        {
            try
            {
                Chipset ChipsetToUpdate = await _IChipsetRepository.GetChipsetByIDAsync(id);
                if(ChipsetToUpdate == null)
                {
                    _Logger.LogError(ControllerContext, $"Error Message: Chipset with the id: {id} is not in the database.");
                    return StatusCode(500, "Internal Server Error.");
                }
                _Logger.LogInfo(ControllerContext, $"Chipset with the id: {id} has been updated.");
                
                ChipsetToUpdate.UpdatedAt = DateTime.Now;
                await _IChipsetRepository.UpdateChipsetAsync(ChipsetToUpdate);
                return NoContent();
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // DELETE api/chipset/delete/id
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteChipset(int id)
        {
            _Logger.LogWarn(ControllerContext, $"Deleting a chipset will delete all CPU information under it and also delete all cpudetails.");
            try
            {
                Chipset ChipsetToDelete = await _IChipsetRepository.GetChipsetByIDAsync(id);
                if(ChipsetToDelete == null)
                {
                    _Logger.LogError(ControllerContext, $"Chipset with id: {id}, hasn't been found in database.");
                    return NotFound();
                }
                _Logger.LogInfo(ControllerContext, $"Chipset with id: {id} has been deleted.");
                await _IChipsetRepository.DeleteChipsetAsync(ChipsetToDelete);
                return NoContent();
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/chipset/count
        [HttpGet("count")]
        public async Task<IActionResult> GetNumberOfChipsets()
        {
            try
            {
                int NumOfChipsets = await _IChipsetRepository.CountNumberOfChipsetsAsync();
                _Logger.LogInfo(ControllerContext, $"There are {NumOfChipsets} chipsets!");
                return Ok(NumOfChipsets);
            }
            catch(Exception ex)
            {
                _Logger.LogError(ControllerContext, $"Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }
    }
}
