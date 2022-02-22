using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TestUsersCopy.Models;

namespace TestUsersCopy.Data.Repositories
{
    public class MotorcycleRepository : IMotorcycleRepository
    {
        NavEcommerceDBfirstEntities19 _storeDB;
        public MotorcycleRepository(NavEcommerceDBfirstEntities19 storeDB)
        {
            _storeDB = storeDB;
        }

        public Motorcycle AddMotorcycle(Motorcycle motorcycle)
        {
            return _storeDB.Motorcycles.Add(motorcycle);
        }

        public IQueryable<Motorcycle> GetAllMotorcyclesIncludeBrandsCategories()
        {
            return _storeDB.Motorcycles.Include(m => m.Brand).Include(m => m.Category);

        }

        public async Task<Motorcycle> GetMotorcycleById(int? id)
        {
            return await _storeDB.Motorcycles.FindAsync(id);
        }

        public async void SaveChanges()
        {
           await _storeDB.SaveChangesAsync();
        }
    }
}