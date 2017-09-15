using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebsiteAssignmentNew.Models
{
    public class ContactModel
    {
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Website { get; set; }

        public bool Artist { get; set; }

        public string ArtistName { get; set; }

        [Required]
        public string Comments { get; set; }
    }
}