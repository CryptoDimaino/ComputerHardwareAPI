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
    public interface IManufacturerRepository : IGenericRepository<Manufacturer>
    {
        Task<IEnumerable<Manufacturer>> GetAllManufacturersAsync();
        Task<Manufacturer> GetManufacturerByIDAsync(int ManufacturerId);
        Task CreateManufacturerAsync(Manufacturer NewManufacturer);
        Task UpdateManufacturerAsync(Manufacturer ManufacturerToUpdate);
        Task DeleteManufacturerAsync(Manufacturer ManufacturerToDelete);
    }
}