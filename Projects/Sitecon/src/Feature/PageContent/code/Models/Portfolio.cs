using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecon.Feature.PageContent.Models
{
   public class Portfolio
    {
        public List<PortfolioImg> PhotoList { get; set; }
    }
  public class PortfolioImg
    {
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int number { get; set; }
    }
}
