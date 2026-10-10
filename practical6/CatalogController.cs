using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoreInventorySystem.Models;

namespace StoreInventorySystem.Controllers
{
    public class CatalogController : Controller
    {
        // GET: Catalog
        public ActionResult Index()
        {
            List<Item> catalogList = LoadInventory();
            return View(catalogList);
        }

        public ActionResult Details(int id)
        {
            List<Item> fullCatalog = LoadInventory();
            Item selectedItem = fullCatalog.FirstOrDefault(i => i.Id == id);
            return View(selectedItem);
        }

        private List<Item> LoadInventory()
        {
            return new List<Item>
            {
                new Item
                {
                    Id = 101,
                    Title = "Smartwatch",
                    Details = "Water-resistant fitness tracker watch",
                    Cost = 4500m,
                    Section = "Wearables"
                },
                new Item
                {
                    Id = 102,
                    Title = "Mechanical Keyboard",
                    Details = "RGB backlit wireless keyboard",
                    Cost = 3200m,
                    Section = "Peripherals"
                },
                new Item
                {
                    Id = 103,
                    Title = "Gaming Mouse",
                    Details = "High-precision ergonomic mouse",
                    Cost = 1500m,
                    Section = "Peripherals"
                }
            };
        }
    }
}