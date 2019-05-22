using ComputerHardware.Models;
using ComputerHardware.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ComputerHardware.Contracts
{
    public interface ICPURepository : IGenericRepository<CPU>
    {
        Task<IEnumerable<CPU>> GetAllCPUsAsync();
        Task<CPU> GetCPUByIDAsync(int CPUId);
        Task CreateCPUAsync(CPU NewCPU);
        Task UpdateCPUAsync(CPU CPUToUpdate);
        Task DeleteCPUAsync(CPU CPUToDelete);
    }
}