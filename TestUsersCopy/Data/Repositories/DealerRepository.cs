using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestUsersCopy.Models;

namespace TestUsersCopy.Data.Repositories
{
    public class DealerRepository : IDealerRepository
    {
        NavEcommerceDBfirstEntities19 _storeDB;
        public DealerRepository(NavEcommerceDBfirstEntities19 storeDB)
        {
            _storeDB = storeDB;
        }
        public List<Dealer> GetDealers()
        {
            return _storeDB.Dealers.ToList();
        }
    }
}