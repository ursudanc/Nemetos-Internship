using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecon.Feature.Navigation.Models
{
    public class Navbar
    {
    public string ImageUrl { get; set; }
    public string ImageAlt { get; set; }
    public string HomeLinkUrl { get; set; }
    public string AboutUsLinkUrl { get; set; }

    public string ServicesLinkUrl { get; set; }
    public string PortfolioLinkUrl { get; set; }
    public string Error404LinkUrl { get; set; }
    public string PrivacyPolicyLinkUrl { get; set; }
    public string  ContactLinkUrl { get; set; }
  }
}
