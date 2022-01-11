using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecon.Feature.PageContent.Models
{
    public class CompanyTeam
    {
        public string Title { get; set; }
        public List<Employee> EmployeesList { get; set; }
    }
  public class Employee
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Presentation { get; set; }
        public string FacebookLink { get; set; }
    public string GoogleLink { get; set; }
    public string TwitterLink { get; set; }
    public string LinkedInLink { get; set; }

  }
}
