using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteAssignmentNew.Models
{
    public class Track
    {
        public string Artist { get; set; }
        public string Title { get; set; }        
        public string TrackCode { get; set; }
        public decimal PriceDownload { get; set; }
        public decimal PriceCD { get; set; }
        public decimal PriceVinyl { get; set; }
        public string TrackImage { get; set; }
        public string TrackAudio { get; set; }       
    }

    //public class FindTracks
    //{
    //    List<Track> artistTrack = new List<Track>();

    //    string duplicates = art 
            
    //        //artistTrack.GroupBy(x => x)
    //        //.Where(x => x.Count() > 1)
    //        //.Select(x => x.Key)
    //        //.ToList();

    //    public string Duplicates { get => duplicates; set => duplicates = value; }
    //}
}