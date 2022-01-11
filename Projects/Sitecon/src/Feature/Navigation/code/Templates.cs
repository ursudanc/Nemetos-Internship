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

    public static class Navbar
    {
      public static class Fields
      {
        public static readonly ID Logo = new ID("{DDA56F00-2464-44F4-820B-7181D0838B27}");
        public static readonly ID HomeLink = new ID("{CD727B13-DB2F-4105-AB09-C8BEDF8DE4A4}");
        public static readonly ID AboutUs = new ID("{497AFA1A-CA56-4E8D-A427-D578C07A5391}");
        public static readonly ID Services= new ID("{67A81094-7BF0-4D2B-BB73-D2A033CD2571}");
        public static readonly ID Portflio = new ID("{33F20AE6-D854-43E3-9B4F-2B95473FF87A}");
        public static readonly ID Error404 = new ID("{D4D5D092-CC63-4449-8D40-AA1525D0ADBC}");
        public static readonly ID PrivacyPolicy = new ID("{66773942-B406-4575-9FD0-063BB91040F4}");
        public static readonly ID Contact = new ID("{CC7F2672-34B4-4942-AC24-B3B8FADC55E4}");
      }
    }

    public static class PageTitle
    {
      public static class Fields
      {
        public static readonly ID Title = new ID("{76540F7F-3EC8-40E1-B95D-6E9CF5701B4D}");
        public static readonly ID HomeLink = new ID("{2362003D-1F1B-4671-B212-495DB4D2C391}");
        
      }
    }
  }
}