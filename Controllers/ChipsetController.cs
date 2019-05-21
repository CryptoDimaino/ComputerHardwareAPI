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
                _Logger.LogInfo($"{SomeHelper.LogInfos(ControllerContext)} Querying all Chipsets!");
                return Ok(await _IChipsetRepository.GetAllChipsetAsync());
            }
            catch(Exception ex)
            {
                _Logger.LogError($"{SomeHelper.LogInfos(ControllerContext)} Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/Chipset/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetChipsetId(int id)
        {
            try
            {
                _Logger.LogInfo($"{SomeHelper.LogInfos(ControllerContext)} Querying Chipset with the id: {id}");
                return Ok(await _IChipsetRepository.GetChipsetByIDAsync(id));
            }
            catch(Exception ex)
            {
                _Logger.LogError($"{SomeHelper.LogInfos(ControllerContext)} Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // DELETE api/Chipset/delete/id
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteChipset(int id)
        {
            _Logger.LogWarn($"Deleting a chipset will delete all CPU information under it and also delete all cpudetails.");
            try
            {
                Chipset ChipsetToDelete = await _IChipsetRepository.GetChipsetByIDAsync(id);
                if(ChipsetToDelete == null)
                {
                    _Logger.LogError($"{SomeHelper.LogInfos(ControllerContext)} Chipset with id: {id}, hasn't been found in db.");
                    return NotFound();
                }
                _Logger.LogInfo($"{SomeHelper.LogInfos(ControllerContext)} Chipset with id: {id} has been deleted.");
                await _IChipsetRepository.DeleteChipsetAsync(ChipsetToDelete);
                return Ok(_IChipsetRepository.GetAllChipsetAsync());
            }
            catch(Exception ex)
            {
                _Logger.LogError($"{SomeHelper.LogInfos(ControllerContext)} Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // POST api/Chipset/CreateNewChipset
        [HttpPost("CreateNewChipset")]
        public async Task<IActionResult> CreateNewChipset()
        {
            Chipset NewChipset = new Chipset()
                {
                    ChipsetId = 3,
                    Name = "nghtry",
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
                _Logger.LogInfo($"Controller: ChipsetController - Method: CreateNewChipset - Creating New Chipset: ChipsetId: {NewChipset.ChipsetId}, Name: {NewChipset.Name}");
                await _IChipsetRepository.CreateChipsetAsync(NewChipset);
                return Ok(_IChipsetRepository.GetAllChipsetAsync());
            }   
            catch(Exception ex)
            {
                _Logger.LogError($"Controller: ChipsetController - Method: CreateNewChipset - Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }
    }
}
