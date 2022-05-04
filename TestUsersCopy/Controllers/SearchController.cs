using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TestUsersCopy.Models;

namespace TestUsersCopy.Controllers
{
    public class SearchController : Controller
    {
        private NavEcommerceDBfirstEntities19 db = new NavEcommerceDBfirstEntities19();

        public SearchController()
        {

        }

        // GET: Search
        public async Task<ActionResult> Index(string search)
        {
            var searchMotorcycle = db.Motorcycles.Where(m => m.Model.Contains(search) || search == null).ToList();
            return View(searchMotorcycle);
        }
    }
}