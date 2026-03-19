using Microsoft.AspNetCore.Mvc;

namespace InventorySystem.Repository.Products
{
    public class ProductsRepository : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
