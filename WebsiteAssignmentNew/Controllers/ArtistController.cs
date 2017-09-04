using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteAssignmentNew.Models;

namespace WebsiteAssignmentNew.Controllers
{
    public class ArtistController : Controller
    {
        // GET: Artist
        public ActionResult Index()
        {


            List<Artist> artistList = new List<Artist>()
            {
                  new Artist{ ArtistName="111", Title="Where Were You",  ArtistImg="111.jpg"},
                  new Artist{ ArtistName="Acid Unit", Title="Taxi",  ArtistImg="AcidUnit.jpg"},
                  new Artist{ ArtistName="Anxiety", Title="Anxiety",  ArtistImg="Anxiety.jpg"},
                  new Artist{ ArtistName="Banter", Title="Banter",  ArtistImg="Banter.jpg"},
            };
            return View(artistList);
            //return View();
        }
    }
}