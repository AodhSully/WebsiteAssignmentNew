using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteAssignmentNew.Models;

namespace WebsiteAssignmentNew.Controllers
{
    public class TracksController : Controller
    {
        //GET: Track
        public ActionResult Index()
        {
            List<Track> tracklist = new List<Track>()
            {
                  new Track{ Artist="111", Title="Where Were You",  TrackCode="BC0001", PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="111.png", TrackAudio="~/Content/tempAudio/111.mp3"},
                  new Track{ Artist="Acid Unit",Title="Taxi", TrackCode="BC0002", PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="AcidUnit.jpg", TrackAudio="~/Content/tempAudio/AcidUnit.mp3"},
                  new Track{ Artist="Anxiety",Title="Anxiety", TrackCode="BC0003", PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M,TrackImage="Anxiety.png", TrackAudio="~/Content/tempAudio/Anxiety.mp3"},
                  new Track{ Artist="Banter",Title="Banter", TrackCode="BC0004", PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Banter.jpg", TrackAudio="~/Content/tempAudio/Banter.mp3"},
            };
            return View(tracklist);
        }
    }
}