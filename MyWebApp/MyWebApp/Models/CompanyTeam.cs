using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Models
{
    public class CompanyTeam 
    {
        public string Title { get; set; }
        public List<Employe> Employer { get; set; }

    }
}