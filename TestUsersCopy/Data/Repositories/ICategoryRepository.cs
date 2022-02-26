using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestUsersCopy.Models;

namespace TestUsersCopy.Data.Repositories
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetCategories();
    }
}
