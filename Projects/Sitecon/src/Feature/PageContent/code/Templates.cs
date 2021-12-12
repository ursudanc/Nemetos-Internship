using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.PageContent
{
  public static class Templates
  {
    public static class BodyCopy
        {
      public static class Fields
            {
        public static readonly ID BodyCopy = new ID("{7A9D1A4A-8735-4DE1-9FE7-4EDDFF01485C}");
            }
        }
    public static class TwoImage
    {
      public static class Fields
      {
        public static readonly ID Image1 = new ID("{567180EF-7CBC-4BD3-AEEA-8D893B57A193}");
        public static readonly ID Image2 = new ID("{08AA4BC0-9473-482B-ADA5-3F029A460DCC}");
      }
    }
    public static class TitleAndText
    {
      public static class Fields
      {
        public static readonly ID ComponentTitle = new ID("{C15FD4DD-CEFD-4796-BCFD-10083A05946B}");
        public static readonly ID ComponentText = new ID("{35A07D38-CF9A-4119-888B-8EA63A3C163B}");
      }
    }
    public static class ListWithIcons
    {
      public static class Fields
      {
        public static readonly ID ListIcon = new ID("{DC31EAEE-0C03-47F5-BAF0-9E7B27075E24}");
        public static readonly ID ListText = new ID("{C4EB4A7F-FB00-4E47-9987-224DDE437AC2}");
      }
    }

    public static class YouTubeVideo
    {
      public static class Fields
      {
        public static readonly ID YouTubeVideoId = new ID("{CB8E6085-F298-48DD-99CC-4B25510F1C0C}");
        
      }
    }
  }
}