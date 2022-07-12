using Delivery.Data;
using Delivery.Models;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Controllers
{
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public OrdersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var objAppOrderList = _db.AppOrders;
            return View(objAppOrderList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Orders obj)
        {
            if (ModelState.IsValid)
            {
                _db.AppOrders.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Все поля должны быть заполнены!";
            return View();
        }
    }
}
