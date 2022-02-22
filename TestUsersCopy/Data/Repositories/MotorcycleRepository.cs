using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
        public IQueryable<Motorcycle> GetAllMotorcyclesIncludeBrandsCategories()
        {
            return _storeDB.Motorcycles.Include(m => m.Brand).Include(m => m.Category);

        }
    }
}