using LittleReadStoreWeb.Data;
using LittleReadStoreWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace LittleReadStoreWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objCategories = _db.Categories.ToList();
            return View(objCategories);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
