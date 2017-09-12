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
                  new Track{ Artist="[deleted]", Title="Roast Me", TrackCode="BC005", PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="deleted.jpg", TrackAudio="[deleted] - Roast Me.mp3"},
                  new Track{ Artist="111", Title="Where Were You",  TrackCode="BC0001", PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="111.png", TrackAudio="111.mp3"},
                  new Track{ Artist="Acid Unit",Title="Taxi", TrackCode="BC0002", PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="AcidUnit.jpg", TrackAudio="AcidUnit.mp3"},
                  new Track{ Artist="Anxiety",Title="Anxiety", TrackCode="BC0003", PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M,TrackImage="Anxiety.png", TrackAudio="Anxiety.mp3"},
                  new Track{ Artist="Banter",Title="Banter", TrackCode="BC0004", PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Banter.jpg", TrackAudio="Banter.mp3"},
                  new Track{ Artist="Battle Ground", Title="Don't Fear Me", TrackCode="BC006",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="BattleGround.png", TrackAudio="BattleGround - Don't Fear Me.mp3"},
                  new Track{ Artist="Box Heads", Title="Enter The Disco", TrackCode="BC007",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="BoxHeads.jpg", TrackAudio="Box Heads - Enter the Disco.mp3"},
                  new Track{ Artist="Bulldozer Preachers", Title="Float On", TrackCode="BC008",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="BulldozerPreachers.png", TrackAudio="Bulldozer.mp3"},
                  new Track{ Artist="Bust", Title="Neckline", TrackCode="BC009",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Bust.jpg", TrackAudio="Bust - Neckline.mp3"},
                  new Track{ Artist="Charles Duke", Title="Lunar Immolation", TrackCode="BC010",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="CharlesDuke.png", TrackAudio="Charles Duke - Lunar Immolation.mp3"},
                  new Track{ Artist="Chicago", Title="Headlights", TrackCode="BC011",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Chicago.png", TrackAudio="Chicago- Headlights.mp3"},
                  new Track{ Artist="Decipher", Title="See You Around", TrackCode="BC012",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Decipher.jpg", TrackAudio="Decipher - See You Around.mp3"},
                  new Track{ Artist="Dino", Title="Roar", TrackCode="BC013",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Dino.jpg", TrackAudio="Dino - Roar.mp3"},
                  new Track{ Artist="Ernie And The Berts", Title="Ruy De Sesame", TrackCode="BC014",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Ernie.jpg", TrackAudio="Ernie And The Berts - Ruy De Sesame.mp3"},
                  new Track{ Artist="Fighting Badgers", Title="Come At Me", TrackCode="BC015",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="fight.png", TrackAudio="Fighting Badgers - Come At Me.MP3"},
                  new Track{ Artist="Gonatozygon", Title="Growing Up", TrackCode="BC016",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Gonatozygon.png", TrackAudio="Gonatozygon - Growing Up.mp3"},
                  new Track{ Artist="Halifax", Title="Armada", TrackCode="BC017",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Halifax1.png", TrackAudio="Halifax - Armada.mp3"},
                  new Track{ Artist="Halifax", Title="Poured Lines", TrackCode="BC018",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Halifax2.png", TrackAudio="Halifax - Poured Lines.mp3"},
                  new Track{ Artist="Hudson", Title="Crossed Paths", TrackCode="BC019",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Hudson.png", TrackAudio="Hudson - Crossed Paths.mp3"},
                  new Track{ Artist="Infinity Mirror", Title="Lone Egret", TrackCode="BC020",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Infinity.jpg", TrackAudio="Infinity Mirror - Lone Egret.mp3"},
                  new Track{ Artist="Jane Doe", Title="Freedom", TrackCode="BC021",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Jane.jpg", TrackAudio="Jane Doe - Freedom.mp3"},
                  new Track{ Artist="Jeb", Title="Jeb", TrackCode="BC022",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Jeb.jpg", TrackAudio="Jeb - Jeb.mp3"},
                  new Track{ Artist="Kobogo", Title="A Bug's Life", TrackCode="BC023",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Kobogo.jpg", TrackAudio="Kobogo - A Bug's Life.MP3"},
                  new Track{ Artist="Kobogo", Title="Never Blend In", TrackCode="BC024",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Kobogo2.jpg", TrackAudio="Kobogo - Never Blend In.mp3"},
                  new Track{ Artist="Legacy Systems", Title="Hell On Earth", TrackCode="BC025",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="LegacyHell.png", TrackAudio="Legacy Systems - Hell On Earth.mp3"},
                  new Track{ Artist="Legacy Systems", Title="How Do I Delete This", TrackCode="BC026",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="LegacyHow.jpg", TrackAudio="Legacy Systems - How Do I Delete This.mp3"},
                  new Track{ Artist="Legacy Systems", Title="Out Of Date", TrackCode="BC027",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="LegacyOut.png", TrackAudio="Legacy Systems - Out Of Date.mp3"},
                  new Track{ Artist="Legacy Systems", Title="These Men Are Not Friends", TrackCode="BC028",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="LegacyFriends.jpg", TrackAudio="Legacy Systems - These Men Are Not Friends.mp3"},
                  new Track{ Artist="Life Arctic", Title="Noise", TrackCode="BC029",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Life.png", TrackAudio="Life Arctic - Noise.mp3"},
                  new Track{ Artist="Lo-Fi Sunrise", Title="Video", TrackCode="BC030",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Lo-Fi.png", TrackAudio="Lo-Fi Sunrise - Video.mp3"},
                  new Track{ Artist="Nebula", Title="I Dont Care", TrackCode="BC031",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="NebulaI.jpg", TrackAudio="Nebula - I Don't Care.mp3"},
                  new Track{ Artist="Nebula", Title="Nebula", TrackCode="BC032",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Nebula.jpg", TrackAudio="Nebula - Nebula.mp3"},
                  new Track{ Artist="Night Terrors", Title="Down", TrackCode="BC033",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Night.png", TrackAudio="Night Terrors - Down.mp3"},
                  new Track{ Artist="Nostromo", Title="Arrival", TrackCode="BC034",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="NostromoArrival.jpg", TrackAudio="Nostromo - Arrival.mp3"},
                  new Track{ Artist="Nostromo", Title="Contact", TrackCode="BC035",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="NostromoContact.jpg", TrackAudio="Nostromo - Contact.mp3"},
                  new Track{ Artist="Nostromo", Title="Countdown", TrackCode="BC036",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="NostromoCountdown.jpg", TrackAudio="Nostromo - Countdown.mp3"},
                  new Track{ Artist="O Douglas", Title="Taste", TrackCode="BC037",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="ODouglas.png", TrackAudio="O Douglas - Taste.mp3"},
                  new Track{ Artist="Perspective Error", Title="Fun Things Are Fun", TrackCode="BC038",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Perspective.png", TrackAudio="Perspective Error - Fun Things Are Fun.mp3"},
                  new Track{ Artist="QR", Title="Code", TrackCode="BC039",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="QR.jpg", TrackAudio="QR - Code.mp3"},
                  new Track{ Artist="Quiche", Title="Midnight Quiche", TrackCode="BC040",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Quiche.jpg", TrackAudio="Quiche - Midnight Quiche.mp3"},
                  new Track{ Artist="Rebekkah", Title="Modern Venus", TrackCode="BC041",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Rebekkah.png", TrackAudio="Rebekkah - Modern Venus.mp3"},
                  new Track{ Artist="Right Hand Man", Title="Sauce", TrackCode="BC042",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Right.jpg", TrackAudio="Right Hand Man - Sauce.mp3"},
                  new Track{ Artist="Rose", Title="Scene", TrackCode="BC043",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Rose.jpg", TrackAudio="Rose - Scene.mp3"},
                  new Track{ Artist="Sama", Title="The Cost Of High Living", TrackCode="BC044",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Sama.png", TrackAudio="Sama - The Cost of High Living.mp3"},
                  new Track{ Artist="Sojourn", Title="Moon", TrackCode="BC045",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="SojournMoon.jpg", TrackAudio="Sojourn - Moon.mp3"},
                  new Track{ Artist="Sojourn", Title="Ocean", TrackCode="BC046",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="SojournOcean.jpg", TrackAudio="Sojourn - Ocean.mp3"},
                  new Track{ Artist="System", Title="Collision", TrackCode="BC047",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="SystemCollision.jpg", TrackAudio="System - Collision.mp3"},
                  new Track{ Artist="The Auditions", Title="Camouflage", TrackCode="BC048",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="TheAuditions.jpg", TrackAudio="The Auditions - Camouflage.mp3"},
                  new Track{ Artist="Tokyo Girl", Title="C.A.", TrackCode="BC049",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Tokyo.jpg", TrackAudio="Tokyo Girl - C.A..mp3"},
                  new Track{ Artist="Tower", Title="Tower", TrackCode="BC050",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Tower.png", TrackAudio="Tower - Tower.mp3"},
                  new Track{ Artist="Trams", Title="Moshi Moshi", TrackCode="BC051",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Trams.png", TrackAudio="Trams - Moshi Moshi.mp3"},
                  new Track{ Artist="Travis Lee", Title="Saints & Sinners", TrackCode="BC052",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Travis.jpg", TrackAudio="Travis Lee - Saints & Sinners.mp3"},
                  new Track{ Artist="Unacceptable Use", Title="Right Side Up", TrackCode="BC053",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Unacceptable.jpg", TrackAudio="Unacceptable Use - Right Side Up.mp3"},
                  new Track{ Artist="Universal Robots", Title="Goodbye", TrackCode="BC054",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Universal.jpg", TrackAudio="Universal Robots - Goodbye.mp3"},
                  new Track{ Artist="Virgin", Title="Virgin", TrackCode="BC055",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Virgin.jpg", TrackAudio="Virgin - Virgin.mp3"},
                  new Track{ Artist="Wilson", Title="LightHouse", TrackCode="BC054",PriceDownload=0.99M, PriceCD=4.99M, PriceVinyl=9.99M, TrackImage="Wilson.jpg", TrackAudio="Wilson - LightHouse.mp3"},



            };
            return View(tracklist);
        }

        //public ActionResult PlayAudio(string TrackAudio)
        //{

        //}
    }
}