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
                  new Artist{ ArtistName="[deleted]", Title="Roast Me",  ArtistImg="[deleted].jpg"},
                   new Artist{ ArtistName="Battle Ground", Title="Don't Fear Me",  ArtistImg="BattleGround.jpg"},
                   new Artist{ ArtistName="Box Heads", Title="Enter The Disco",  ArtistImg="BoxHeads.jpg"},
                   new Artist{ ArtistName="Bulldozer Preachers", Title="Float On",  ArtistImg="BulldozerPreachers.jpg"},
                   new Artist{ ArtistName="Bust", Title="Neckline",  ArtistImg="Bust.jpg"},
                   new Artist{ ArtistName="Charles Duke", Title="Lunar Immolation",  ArtistImg="Charles.jpg"},
                   new Artist{ ArtistName="Chicago", Title="Headlights",  ArtistImg="Chicago.jpg"},
                   new Artist{ ArtistName="Decipher", Title="See You Around",  ArtistImg="Decipher.jpg"},
                   new Artist{ ArtistName="Dino", Title="Roar",  ArtistImg="Dino.jpg"},
                   new Artist{ ArtistName="Ernie And The Berts", Title="Ruy De Sesame",  ArtistImg="Ernie.jpg"},
                   new Artist{ ArtistName="Fighting Badgers", Title="Come At Me",  ArtistImg="Fighting.jpg"},
                   new Artist{ ArtistName="Gonatozygon", Title="Growing Up",  ArtistImg="Gonatozygon.jpg"},
                   
                    new Artist{ ArtistName="Halifax", Title="Armada & Poured Lines",  ArtistImg="Halifax.jpg"},
                    new Artist{ ArtistName="Hudson", Title="Crossed Paths",  ArtistImg="Hudson.jpg"},

                new Artist{ ArtistName="Infinity Mirror", Title="Lone Egret",  ArtistImg="Infinity.jpg"},

                new Artist{ ArtistName="Jane Doe", Title="Freedom",  ArtistImg="Jane.png"},
                    new Artist{ ArtistName="Jeb", Title="Jeb",  ArtistImg="jeb.jpg"},
                    new Artist{ ArtistName="Kobogo", Title="A Bug's Life & Never Blend In",  ArtistImg="Kobogo.jpg"},

                new Artist{ ArtistName="Legacy Systems", Title="Hell On Earth, How Do I Delete This, These Men Are Not Friends & Out Of Date",  ArtistImg="Legacy.jpg"},
                    new Artist{ ArtistName="Life Arctic", Title="Noise",  ArtistImg="Life.jpg"},
                    new Artist{ ArtistName="Lo-Fi Sunrise", Title="Video",  ArtistImg="Lo-Fi.jpg"},
                    new Artist{ ArtistName="Nebula", Title="I Dont Care, Nebula & Down",  ArtistImg="Nebula.jpg"},
                    new Artist{ ArtistName="Nostromo", Title="Arrival, Contact & Countdown",  ArtistImg="Nostromo.jpg"},
                    new Artist{ ArtistName="O Douglas", Title="Taste",  ArtistImg="ODouglas.jpg"},
                    new Artist{ ArtistName="Perspective Error", Title="Fun Things Are Fun",  ArtistImg="Perspective.jpg"},
                    new Artist{ ArtistName="QR", Title="Code",  ArtistImg="QR.jpg"},
                    new Artist{ ArtistName="Quiche", Title="Midnight Quiche",  ArtistImg="Quiche.jpg"},






            };
            return View(artistList);
            //return View();
        }
    }
}