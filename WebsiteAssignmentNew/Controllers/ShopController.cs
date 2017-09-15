using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteAssignmentNew.Models;

namespace WebsiteAssignmentNew.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index()
        {
            List<Shop> shoplist = new List<Shop>()
            {
                new Shop{Item="Eyes Hat", Description="hat", ItemCode="BC1001", Price=5.99m, ItemImage="hat1.png"},
                new Shop{Item="Logo Hat", Description="hat", ItemCode="BC1002", Price=5.99m, ItemImage="hat2.png"},
                new Shop{Item="Logo Text Hat", Description="hat 3", ItemCode="BC1003", Price=5.99m, ItemImage="hat3.png"},
                new Shop{Item="Logo Text White Hat ", Description="Hat", ItemCode="BC1004", Price=5.99m, ItemImage="hat4.png"},
                new Shop{Item="Eyes Sticker Sheet", Description="stickerSheet", ItemCode="BC1005", Price=3.99m, ItemImage="Sticker1.png"},
                new Shop{Item="Logo Text Sticker Sheet", Description="stickerSheet", ItemCode="BC1006", Price=3.99m, ItemImage="Sticker2.png"},
                new Shop{Item="Mens Logo T-Shirt", Description="tshirt", ItemCode="BC1007", Price=15.99m, ItemImage="tshirt1.png"},
                new Shop{Item="Womens Red Logo T-Shirt", Description="tshirt", ItemCode="BC1008", Price=15.99m, ItemImage="tshirt2.png"},
                new Shop{Item="Mens Logo Text T-Shirt", Description="tshirt", ItemCode="BC1009", Price=15.99m, ItemImage="tshirt3.png"},
                new Shop{Item="Mens Logo Text Red T-Shirt", Description="tshirt", ItemCode="BC1010", Price=15.99m, ItemImage="tshirt4.png"},
                new Shop{Item="Logo Text Hoodie", Description="hoodie", ItemCode="BC1011", Price=15.99m, ItemImage="hoodie11.png"},
                new Shop{Item="Logo Eyes Hoodie", Description="hoodie", ItemCode="BC1012", Price=15.99m, ItemImage="hoodie22.png"},
            };
            return View(shoplist);
        }
    }
}