using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecon.Feature.PageContent.Models
{
    public class Services
    {
        public List<ServiceComponent> ComponentList { get; set; }
        public string Link { get; set; }
        public string Text { get; set; }
    }
  public class ServiceComponent
    {
        public string Icon { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int nr { get; set; }

    }
}
