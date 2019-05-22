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
    public class SocketRepository : GenericRepository<Socket>, ISocketRepository
    {
        public SocketRepository(Context Context) : base(Context)
        {

        }

        public async Task<IEnumerable<Socket>> GetAllSocketsAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<Socket> GetSocketByIDAsync(int SocketId)
        {
            return await FindByCondition(c => c.SocketId == SocketId).FirstOrDefaultAsync();
        }

        public async Task CreateSocketAsync(Socket NewSocket)
        {
            Create(NewSocket);
            await SaveAsync();
        }

        public async Task UpdateSocketAsync(Socket SocketToUpdate)
        {
            Update(SocketToUpdate);
            await SaveAsync();
        }

        public async Task DeleteSocketAsync(Socket SocketToDelete)
        {
            Delete(SocketToDelete);
            await SaveAsync();
        }
    }
}