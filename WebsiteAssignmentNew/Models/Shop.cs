using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebsiteAssignmentNew.Models
{
    public class Shop
    {
        public string Item { get; set; }
        public string Description{ get; set; }        
        public string ItemCode { get; set; }
        public decimal Price { get; set; }
        public string ItemImage { get; set; }
    }
}