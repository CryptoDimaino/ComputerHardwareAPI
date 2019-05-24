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
    public interface ISocketRepository : IGenericRepository<Socket>
    {
        Task<IEnumerable<Socket>> GetAllSocketsAsync();
        Task<Socket> GetSocketByIDAsync(int SocketId);
        Task<Socket> GetSocketByNameAsync(string Name);
        Task CreateSocketAsync(Socket NewSocket);
        Task UpdateSocketAsync(Socket SocketToUpdate);
        Task DeleteSocketAsync(Socket SocketToDelete);
        Task<int> CountNumberOfSocketsAsync();

        Task<IEnumerable<SocketDTO>> GetAllSocketDTOsAsync();
    }
}