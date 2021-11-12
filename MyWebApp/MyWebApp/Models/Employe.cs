using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Models
{
    public class Employe
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string Intro { get; set; }
        public SocialMedia SocialMedia { get; set; }

    }
}