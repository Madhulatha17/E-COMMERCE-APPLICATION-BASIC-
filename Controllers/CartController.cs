using Microsoft.AspNetCore.Mvc;
using ECommerceApp.Models;

namespace ECommerceApp.Controllers
{
    public class CartController : Controller
    {
        private static List<CartItem> cart =
            new List<CartItem>();

        public IActionResult Index()
        {
            return View(cart);
        }

        public IActionResult Add(
            int id,
            string name,
            decimal price)
        {
            cart.Add(
                new CartItem
                {
                    ProductId = id,
                    ProductName = name,
                    Price = price,
                    Quantity = 1
                });

            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            var item =
                cart.FirstOrDefault(
                    x => x.ProductId == id);

            if (item != null)
                cart.Remove(item);

            return RedirectToAction("Index");
        }
    }
}
