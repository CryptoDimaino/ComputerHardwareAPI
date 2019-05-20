using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ComputerHardware.Contracts;
using ComputerHardware.Models;
using Microsoft.EntityFrameworkCore;
using ComputerHardware.Repositories;

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
                _Logger.LogInfo("Controller: ChipsetController - Method: GetChipsets - Querying all Chipsets!");
                return Ok(await _IChipsetRepository.GetAllChipsetAsync());
            }
            catch(Exception ex)
            {
                _Logger.LogError($"Controller: ChipsetController - Method: GetChipsets - Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // GET api/Chipset/id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetChipsetId(int id)
        {
            try
            {
                _Logger.LogInfo($"Controller: ChipsetController - Method: GetChipsetId - Querying Chipset with the id: {id}");
                return Ok(await _IChipsetRepository.GetChipsetByIDAsync(id));
            }
            catch(Exception ex)
            {
                _Logger.LogError($"Controller: ChipsetController - Method: GetChipsetId - Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // POST api/Chipset/Delete/id
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteChipset(int id)
        {
            try
            {
                Chipset ChipsetToDelete = await _IChipsetRepository.GetChipsetByIDAsync(id);
                // if(ChipsetToDelete == null)
                // {
                //     _Logger.LogError($"Chipset with id: {id}, hasn't been found in db.");
                //     return NotFound();
                // }
                await _IChipsetRepository.DeleteChipsetAsync(ChipsetToDelete);
                return Ok(_IChipsetRepository.GetAllChipsetAsync());
            }
            catch(Exception ex)
            {
                _Logger.LogError($"Controller: ChipsetController - Method: GetChipsetId - Error Message: {ex.Message}");
                return StatusCode(500, "Internal Server Error.");
            }
        }

        // // POST api/Chipset/CreateNewChipset
        // [HttpGet("CreateNewChipset")]
        // public async Task<IActionResult> CreateNewChipset(Chipset NewChipset)
        // {
        //     try
        //     {
        //         _Logger.LogInfo($"Controller: ChipsetController - Method: CreateNewChipset - Creating New Chipset: ChipsetId: {NewChipset.ChipsetId}, Name: {NewChipset.Name}");
        //         //return Ok(await);
        //     }   
        //     catch(Exception ex)
        //     {
        //         _Logger.LogError($"Controller: ChipsetController - Method: CreateNewChipset - Error Message: {ex.Message}");
        //         return StatusCode(500, "Internal Server Error.");
        //     }
        // }
    }
}
