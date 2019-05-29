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

        public async Task<CPU> GetCPUByNameAsync(string Name)
        {
            return await FindByCondition(c => c.Name == Name).Include(c => c.Socket).Include(c => c.Manufacturer).Include(c => c.Chipset).Include(c => c.CPUDetail).FirstOrDefaultAsync();
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

        public async Task<int> CountNumberOfCPUsAsync()
        {
            return await CountAsync();
        }

        public async Task<IEnumerable<CPUDTO>> GetAllCPUDTOsAsync()
        {
            return await GetAll().Select(s => new CPUDTO
            {
                CPUId = s.CPUId,
                Name = s.Name,
                CoreCount = s.CoreCount,
                ThreadCount = s.ThreadCount,
                BaseFrequency = s.BaseFrequency,
                MaxFrequency = s.MaxFrequency,
                L3Cache = s.L3Cache,
                TDP = s.TDP
            }).ToListAsync();
        }
    }
}