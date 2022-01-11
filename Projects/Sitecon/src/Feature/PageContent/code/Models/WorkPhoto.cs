using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecon.Feature.PageContent.Models
{
   public class WorkPhoto
    {
    public string WorkPhotoImageUrl { get; set; }
        public string WorkPhotoText { get; set; }
        public string WorkPhotoFullImageUrl { get; set; }
        public int number { get; set; }
    }

  public class MainWorkPhoto
  {
    public string Title { get; set; }
    public string Text { get; set; }
    public List<WorkPhoto> MainWorkPhotoList { get; set; }

  }

}
