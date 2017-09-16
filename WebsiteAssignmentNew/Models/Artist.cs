using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteAssignmentNew.Models
{
    public class Artist : Track
    {
        public string ArtistName { get; set; }
        public string TrackTitle { get; set; }
        public string ArtistImg { get; set; }


    }
}

    //public class CompareLists
    //{
       

    //    List<Artist> ArtistName = new List<Artist>();
    //    List<Track> Artist = new List<Track>();
    //    List<Artist> ArtistNameInArtist = new List<Artist>();

       

    ////    string ArtistNameInArtist = from first in ArtistName
    ////                                join second in Artist
    ////                                on first.ArtistName equals second.Artist
    ////                                select first;
    ////}

    //}