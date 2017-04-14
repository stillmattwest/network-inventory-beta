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
        
        public ViewResult Index(string locationString,string manString,string modelString,string snString,string sortOrder)
        {
            
            // persist search data
            ViewBag.locationString = locationString;
            ViewBag.manString = manString;
            ViewBag.modelString = modelString;
            ViewBag.snString = snString;


            IQueryable<InventoryItem> resultItems = db.InventoryItems;

            if (!String.IsNullOrEmpty(snString))
            {
                var snCheck = resultItems
                    .Where(i => i.SerialNumber.ToLower() == snString.ToLower());
                if (snCheck.Any())
                {
                    // if there is an exact match on SN, return result
                    return View(snCheck);
                }

                resultItems = resultItems
                    .Where(i => i.SerialNumber.ToLower().Contains(snString.ToLower()));
            }

            if (!String.IsNullOrEmpty(locationString)) {
                resultItems = resultItems
                    .Where(i => i.Location.ToLower().Contains(locationString.ToLower()));
            }
            if (!String.IsNullOrEmpty(manString))
            {
                resultItems = resultItems
                    .Where(i => i.Manufacturer.ToLower().Contains(manString.ToLower()));
            }
            if (!String.IsNullOrEmpty(modelString))
            {
                resultItems = resultItems
                    .Where(i => i.ModelNumber.ToLower().Contains(modelString.ToLower()));
            }
            
            switch (sortOrder)
            {
                case "location":
                    resultItems = resultItems.OrderBy(i => i.Location);
                    break;
                case "sn":
                    resultItems = resultItems.OrderBy(i => i.SerialNumber);
                    break;
                case "man":
                    resultItems = resultItems.OrderBy(i => i.Manufacturer);
                    break;
                case "model":
                    resultItems = resultItems.OrderBy(i => i.ModelNumber);
                    break;
                case "asset":
                    resultItems = resultItems.OrderBy(i => i.AssetNumber);
                    break; 
                default:
                    resultItems = resultItems.OrderBy(i => i.ItdId);
                    break;
            }
            
            

            return View(resultItems);
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