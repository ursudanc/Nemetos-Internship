using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.Navigation
{
  public static class Templates
  {
    public static class Header
        {
      public static class Fields
            {
        public static readonly ID Logo = new ID("{394AAD25-706D-49FC-A91A-EA5844D01AE5}");
        public static readonly ID HomeLink = new ID("{86AE9525-421F-453D-A949-19F4E0E8C9AB}");
        public static readonly ID EventsRoot = new ID("{AA3F3C9B-6F74-4F58-BA80-406AF6200030}");
        public static readonly ID ScheduleLink = new ID("{EED5B373-3BA5-4160-AEE8-EE7CA5DA373D}");
      }
        }

    public static class Footer
    {
      public static class Fields
      {
        public static readonly ID FooterTextLeft = new ID("{CBC1680B-A355-48E9-9B15-A408691CBC67}");
        public static readonly ID FooterLinkLeft= new ID("{659342D7-32E5-4D0D-A79D-DC6EC6D1399A}");
        public static readonly ID FooterLinkTextLeft = new ID("{46FE73F1-D430-4002-8E52-CEB480D997BC}");
        public static readonly ID FooterTextRight = new ID("{A6215BFA-A8DB-4A3F-8ABD-87A8C2EF1C68}");
        public static readonly ID FooterLinkRight = new ID("{6C746841-DC85-490D-95E2-0923E91B8923}");
        public static readonly ID FooterLinkTextRight = new ID("{66F1F1A5-2E70-4C75-81D7-2EA0925AACBD}");

      }
    }
  }
}