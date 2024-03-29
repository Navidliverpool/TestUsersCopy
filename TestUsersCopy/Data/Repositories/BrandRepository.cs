﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestUsersCopy.Models;

namespace TestUsersCopy.Data.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        NavEcommerceDBfirstEntities19 _storeDB;
        public BrandRepository(NavEcommerceDBfirstEntities19 storeDB)
        {
            _storeDB = storeDB;
        }
        public IQueryable<Brand> GetBrands()
        {
            return _storeDB.Brands;
        }
    }
}