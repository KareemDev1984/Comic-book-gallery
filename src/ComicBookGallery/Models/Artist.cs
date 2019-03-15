using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public Artist(string name, string role)
        {

            Name = name;
            Role = role;
        }

        public Artist()
        {
        }
    }
  
}