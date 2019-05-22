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
    public class CPURepository : GenericRepository<CPU>, ICPURepository
    {
        public CPURepository(Context Context) : base(Context)
        {

        }

        public async Task<IEnumerable<CPU>> GetAllCPUsAsync()
        {
            return await GetAll().Include(c => c.CPUDetail).ToListAsync();
        }

        public async Task<CPU> GetCPUByIDAsync(int CPUId)
        {
            return await FindByCondition(c => c.CPUId == CPUId).Include(c => c.Socket).Include(c => c.Manufacturer).Include(c => c.Chipset).Include(c => c.CPUDetail).FirstOrDefaultAsync();
        }

        public async Task CreateCPUAsync(CPU NewCPU)
        {
            Create(NewCPU);
            await SaveAsync();
        }

        public async Task UpdateCPUAsync(CPU CPUToUpdate)
        {
            Update(CPUToUpdate);
            await SaveAsync();
        }

        public async Task DeleteCPUAsync(CPU CPUToDelete)
        {
            Delete(CPUToDelete);
            await SaveAsync();
        }
    }
}