using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecon.Feature.PageContent.Models
{
   public class MainInfo
    {

    public string ParagraphIcon { get; set; }
    public string ParagraphTitle { get; set; }
    public string ParagraphText { get; set; }
        public int number { get; set; }

    }
  public class FeaturedMainInfo
  {
    public string FeaturedMainInfoTitle { get; set; }
    public string FeaturedMainInfoText { get; set; }
        public List<MainInfo> MainInfoList { get; set; }

    }
}
