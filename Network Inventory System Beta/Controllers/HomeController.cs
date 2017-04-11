using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Network_Inventory_System_Beta.DAL;
using Network_Inventory_System_Beta.Models;

namespace Network_Inventory_System_Beta.Controllers
{
    public class HomeController : Controller
    {
        private InventoryContext db = new InventoryContext();
        
        public ActionResult Index()
        {
            var allItems = db.InventoryItems.OrderBy(item => item.ItdId);
            return View(allItems);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}