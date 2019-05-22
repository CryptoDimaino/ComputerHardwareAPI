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
    public class ManufacturerRepository : GenericRepository<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(Context Context) : base(Context)
        {

        }

        public async Task<IEnumerable<Manufacturer>> GetAllManufacturersAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<Manufacturer> GetManufacturerByIDAsync(int ManufacturerId)
        {
            return await FindByCondition(c => c.ManufacturerId == ManufacturerId).FirstOrDefaultAsync();
        }

        public async Task CreateManufacturerAsync(Manufacturer NewManufacturer)
        {
            Create(NewManufacturer);
            await SaveAsync();
        }

        public async Task UpdateManufacturerAsync(Manufacturer ManufacturerToUpdate)
        {
            Update(ManufacturerToUpdate);
            await SaveAsync();
        }

        public async Task DeleteManufacturerAsync(Manufacturer ManufacturerToDelete)
        {
            Delete(ManufacturerToDelete);
            await SaveAsync();
        }
    }
}