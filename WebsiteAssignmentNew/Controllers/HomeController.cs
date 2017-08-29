using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;

namespace WebsiteAssignmentNew.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string pass1 = "blue";
            string pass2 = "green"; //to show failure

            string hashedValue = Crypto.HashPassword(pass1);

            if (Crypto.VerifyHashedPassword(hashedValue, pass2))
            {
                ViewBag.Value = "Both Passwords Match";
            }
            else ViewBag.Value = "Error! Passwords do not match";

            return View();
        }
    }
}