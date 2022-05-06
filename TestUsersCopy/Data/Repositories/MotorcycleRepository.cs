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

        public MotorcycleRepository()
        {

        }

        public void AddMotorcycle(Motorcycle motorcycle)
        {
            _storeDB.Motorcycles.Add(motorcycle);
        }

        public IQueryable<Motorcycle> GetMotorcyclesIncludeBrandsCategories()
        {
            return _storeDB.Motorcycles.Include(m => m.Brand).Include(m => m.Category);

        }

        public async Task<Motorcycle> GetMotorcycleById(int? id)
        {
            return await _storeDB.Motorcycles.FindAsync(id);
        }

        public Motorcycle GetMotorcycleIncludeItsDealers(int? id)
        {
            return _storeDB.Motorcycles.Include(i => i.Dealers).First(i => i.MotorcycleId == id);
        }

        public async void SaveChanges()
        {
           await _storeDB.SaveChangesAsync();
        }

        public IQueryable<Motorcycle> GetMotorcycles()
        {
            return _storeDB.Motorcycles;
        }


        ////This method was suppose to be used for refactoring the project in order to implement DI. But I undo it for now.
        //void IDbCommon<MotorcycleVM>.EntryState(MotorcycleVM motorcycleVM)
        //{
        //    _storeDB.Entry(motorcycleVM).State = System.Data.Entity.EntityState.Modified;
        //    _storeDB.SaveChanges();
        //}
    }
}