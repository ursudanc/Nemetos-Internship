using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace Sitecon.Feature.Events
{
  public static class Templates
  {
    public static class Speaker
        {
      public static class Fields
            {
        public static readonly ID SpeakerName = new ID ("{7BF1CC90-CD8D-4931-BB06-BBE3A48A333E}");
        public static readonly ID SpeakerTitle = new ID("{891DD14F-7698-40DD-8471-0A8085A7330B}");
        public static readonly ID SpeakerImage = new ID("{CBC8C97A-086C-4EC1-B5DA-4F2EDE64651E}");
        public static readonly ID SpeakerDescription = new ID("{DD57A2BB-BCE0-4D1B-8F22-9D0D1A4D2693}");
        public static readonly ID SpeakerTwitterUrl = new ID("{81F979BE-A547-41AB-A163-EA26B4478C3C}");
        public static readonly ID SpeakerLinkedInUrl = new ID("{CEB344B3-4AD7-4FCC-B5FB-802FE52C0B58}");
        public static readonly ID SpeakerWebsiteUrl = new ID("{0D11170E-B6F4-4031-84D9-978E41C9AA0B}");
      }
        }

    public static class FeaturedSpeaker
    {
      public static class Fields
      {
        public static readonly ID FeaturedSpeakersTitle = new ID("{BB73671F-59DE-4739-BC06-C51BEBDCB738}");
        public static readonly ID FeaturedSpeakersText = new ID("{9B386A81-BCCD-4D09-B8AA-CDBCD177D55F}");
        public static readonly ID FeaturedSpeaker = new ID("{16F11AD2-F15D-4E3A-AAED-D6A160026FB3}");
        public static readonly ID FeaturedSpeakersList = new ID("{58149CFA-7D2A-4C3A-8C6C-591AC0CFAB23}");
      
      }
    }
    public static class Event
    {
      public static class Fields
      {
        public static readonly ID EventName = new ID("{B0B85D9A-3D4D-4A8F-8861-120DFBD0EE33}");
        public static readonly ID EventDate = new ID("{63007D9F-957B-4011-82C2-E396C85A7593}");
        public static readonly ID IsFeaturedEvent = new ID("{BCC8307E-A604-4D2F-BF67-BF467F4F443B}");
        public static readonly ID EventSpeakers = new ID("{AF15B150-7784-4CB5-A3A3-D152369E59BF}");

      }
    }

    public static class EventSchedule
    {
      public static class Fields
      {
        public static readonly ID EventScheduleBackground = new ID("{D8EFA79A-A7B4-4793-818B-E61ED0236FA5}");
        public static readonly ID EventScheduleTitle = new ID("{8CB02486-D3BD-4814-8D45-BF88945040F9}");
        public static readonly ID EventScheduleDay1Title = new ID("{BEE500CF-CDD8-4C03-8949-29E11E647BF9}");
        public static readonly ID EventScheduleDay1Date = new ID("{644ECC7C-8BFF-4216-966D-B24DEE41A526}");
        public static readonly ID EventScheduleDay1Location = new ID("{411F8C30-DB82-4DBD-82AE-FBA15244DE26}");
        public static readonly ID EventScheduleDay1Events = new ID("{FF991BD6-4BBF-498E-B2CB-535D6F5F2E20}");
        public static readonly ID EventScheduleDay2Title = new ID("{B947F6CF-5219-455A-9B98-ED2AC4FA777F}");
        public static readonly ID EventScheduleDay2Date = new ID("{05C58ED7-7E7E-456C-A950-6A16E2EC3468}");
        public static readonly ID EventScheduleDay2Location = new ID("{BD13723C-559D-4EA2-9897-332F88123647}");
        public static readonly ID EventScheduleDay2Events = new ID("{333A694B-D541-4DB3-AFC0-3F7068EEC64A}");

      }
    }

  }
}