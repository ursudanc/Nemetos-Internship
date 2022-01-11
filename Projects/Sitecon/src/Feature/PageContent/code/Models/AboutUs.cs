using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecon.Feature.PageContent.Models
{
  public class Bar
  {
    public string Title { get; set; }
    public string BarColour { get; set; }
    public string WidthPercentage { get; set; }
  }
  public class AboutUsText
  {
        public string Title { get; set; }
        public string Text { get; set; }
        public string href { get; set; }
        public string id { get; set; }

  }
  public class AboutUs
  {
    public string LeftTitle { get; set; }
    public string LeftText { get; set; }
        public string LeftBottomTitle { get; set; }
        public List<Bar> BottomList { get; set; }
    public string RightTitle { get; set; }
    public List<AboutUsText> RightList { get; set; }
    public string RightBottomTitle { get; set; }
    public string RightBottomText { get; set; }

  }
}
