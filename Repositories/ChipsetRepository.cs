using ComputerHardware.Models;
using ComputerHardware.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace ComputerHardware.Repositories
{
    public class ChipsetRepository : GenericRepository<Chipset>, IChipsetRepository
    {
        public ChipsetRepository(Context Context) : base(Context)
        {

        }

        public async Task<IEnumerable<Chipset>> GetAllChipsetsAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<Chipset> GetChipsetByIDAsync(int ChipsetId)
        {
            return await FindByCondition(c => c.ChipsetId == ChipsetId).FirstOrDefaultAsync();
        }

        public async Task<Chipset> GetChipsetByNameAsync(string Name)
        {
            return await FindByCondition(c => c.Name == Name).FirstOrDefaultAsync();
        }

        public async Task CreateChipsetAsync(Chipset NewChipset)
        {
            Create(NewChipset);
            await SaveAsync();
        }

        public async Task UpdateChipsetAsync(Chipset ChipsetToUpdate)
        {
            Update(ChipsetToUpdate);
            await SaveAsync();
        }

        public async Task DeleteChipsetAsync(Chipset ChipsetToDelete)
        {
            Delete(ChipsetToDelete);
            await SaveAsync();
        }

        public async Task<int> CountNumberOfChipsetsAsync()
        {
            return await CountAsync();
        }
    }
}