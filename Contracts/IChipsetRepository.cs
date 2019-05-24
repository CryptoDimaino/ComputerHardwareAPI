using ComputerHardware.Models;
using ComputerHardware.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ComputerHardware.DTOs;

namespace ComputerHardware.Contracts
{
    public interface IChipsetRepository : IGenericRepository<Chipset>
    {
        Task<IEnumerable<Chipset>> GetAllChipsetsAsync();
        Task<Chipset> GetChipsetByIDAsync(int ChipsetId);
        Task<Chipset> GetChipsetByNameAsync(string Name);
        Task CreateChipsetAsync(Chipset NewChipset);
        Task UpdateChipsetAsync(Chipset ChipsetToUpdate);
        Task DeleteChipsetAsync(Chipset ChipsetToDelete);
        Task<int> CountNumberOfChipsetsAsync();
    }
}