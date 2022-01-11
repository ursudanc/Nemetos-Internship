using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sitecon.Feature.PageContent.Models
{
  public class CarouselPhoto
  {
    public string CarouselItemImageUrl { get; set; }
  }
  public class CarouselItem
    {
        public List<CarouselPhoto> CarouselItemList { get; set; }
    }
  
  public class Carousel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public List<CarouselItem> CarouselList { get; set; }
    }
}
