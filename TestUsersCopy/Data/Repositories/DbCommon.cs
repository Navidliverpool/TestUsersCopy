using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestUsersCopy.Models;

namespace TestUsersCopy.Data.Repositories
{
    //This interface was suppose to be used for refactoring the project in order to implement DI. But I undo it and it's dependencies for now.
    public class DbCommon<MotorcycleVM> : IDbCommon<MotorcycleVM>
    {
        private readonly NavEcommerceDBfirstEntities19 _db;
            public DbCommon(NavEcommerceDBfirstEntities19 db)
        {
            _db = db;
        }

        public void EntryState(MotorcycleVM motorcycleVM)
        {
            _db.Entry(motorcycleVM).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }
    }
}