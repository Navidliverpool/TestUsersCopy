using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TestUsersCopy.Models;

namespace TestUsersCopy.Data.Repositories
{
    public interface IMotorcycleRepository
    {
        IQueryable<Motorcycle> GetMotorcyclesIncludeBrandsCategories();
        Task<Motorcycle> GetMotorcycleById(int? id);

        Motorcycle AddMotorcycle(Motorcycle motorcycle);
        void SaveChanges();
        Motorcycle GetMotorcycleIncludeItsDealers(int? id);
    }
}