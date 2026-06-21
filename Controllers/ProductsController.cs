using Microsoft.AspNetCore.Mvc;
using ECommerceApp.Models;

namespace ECommerceApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(
                _context.Products.ToList()
            );
        }

        public IActionResult Details(int id)
        {
            var product =
                _context.Products.Find(id);

            return View(product);
        }
    }
}
