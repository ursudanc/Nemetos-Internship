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

    public static class Slider
    {
      public static class Fields
      {
        public static readonly ID Title1 = new ID("{32D268A0-AF46-413D-9289-E2910793FE0C}");
        public static readonly ID Text1 = new ID("{25984BBA-3D46-4353-9D7F-3ECF2BB0E22B}");
        public static readonly ID Image1 = new ID("{73B8DD69-1FB6-4BB0-BE7F-ED0E51B5916D}");
        public static readonly ID Title2 = new ID("{28BF8948-4E22-44B6-B9C0-C13E56C96410}");
        public static readonly ID Text2 = new ID("{74411869-9B6A-4089-8C4B-6BDD1C488607}");
        public static readonly ID Image2 = new ID("{63E841A4-462C-4FA1-AE9B-1AE2F4DAA5A7}");
        public static readonly ID Title3 = new ID("{8E5E4CFB-694D-49BB-A533-7973C128C542}");
        public static readonly ID Text3 = new ID("{B58BC626-2D2E-46DC-BA28-2A2E3B837E0D}");
        public static readonly ID Image3 = new ID("{D3BBEB71-9034-4344-84C0-963A36803088}");

      }
    }

    public static class IndexPart1
    {
      public static class Fields
      {
        public static readonly ID Title = new ID("{8392351D-18FB-4FDB-918F-ED18C52A9BFD}");
        public static readonly ID Text = new ID("{040F6FD5-0086-43A2-9A31-07F8213CE411}");
        public static readonly ID Link = new ID("{7E823080-21E9-4179-B186-453F0F95E1CA}");

      }
    }

    public static class MainInfo
    {
      public static class Fields
      {
        public static readonly ID Title = new ID("{DA24A000-7174-4D0D-9781-58B07E95632E}");
        public static readonly ID Text = new ID("{57E7CFA3-CC2F-4EFB-B5A4-8FC90C3EE25C}");
        public static readonly ID ParagraphIcon = new ID("{C3071F55-BBF5-4618-9429-BAC2503C72A4}");
      }
    }

    public static class FeaturedMainInfo
    {
      public static class Fields
      {
        public static readonly ID FeaturedMainInfoTitle = new ID("{35EEDA29-9F14-429F-A9B7-093251544B3A}");
        public static readonly ID FeaturedMainInfoText = new ID("{AC94C092-F966-4B76-A207-249BE859800D}");
        public static readonly ID FeaturedMainInfoList = new ID("{D10C4A95-8760-4F93-8E3F-F96233FCC085}");
      }
    }
    public static class WorkPhoto
    {
      public static class Fields
      {
        public static readonly ID Image = new ID("{F493098D-BDBB-412B-84F8-8F4B1915DE92}");
        public static readonly ID Text = new ID("{40B0AE3E-BD4A-4AEE-A7F8-470BF7ADD243}");
        public static readonly ID ImageFull = new ID("{1FDCE15A-3ED4-4BAC-BAC9-26750D6FD0B3}");

      }
    }

    public static class MainWorkPhotos
    {
      public static class Fields
      {
        public static readonly ID Title = new ID("{53D83CB6-68C0-44C0-86C2-0AEAC21295AB}");
        public static readonly ID Text = new ID("{EA53493F-E8B8-4F16-AFD4-72897CA3731F}");
        public static readonly ID PhotosList = new ID("{D75B3910-2592-4184-9187-66ED1480950C}");

      }
    }

    public static class CarouselItem
    {
      public static class Fields
      {
        public static readonly ID ImageList = new ID("{64C0F33C-6DCB-4819-ACCD-85F866626781}");
        
      }
    }

    public static class CarouselPhoto
    {
      public static class Fields
      {
        public static readonly ID Image = new ID("{942EF3C3-6703-43EC-B2E3-E9DEA6629020}");

      }
    }

    public static class Carousel
    {
      public static class Fields
      {
        public static readonly ID Title = new ID("{5AA42E52-2295-43ED-97BD-B362060A637B}");
        public static readonly ID Text = new ID("{BE853236-19FC-48C6-8BC7-8744258888EA}");
        public static readonly ID Items= new ID("{47E828C4-D2CE-4148-AF55-ECB37B29023D}");

      }
    }


    public static class AboutUsText
    {
      public static class Fields
      {
        public static readonly ID Title = new ID("{26D2C44D-50D8-4A23-A112-B12881A133C3}");
        public static readonly ID Text = new ID("{E03F7B27-BC6F-4936-86B7-6BB52D58B5BB}");
       

      }
    }

    public static class Bar
    {
      public static class Fields
      {
        public static readonly ID Title = new ID("{B09A151F-2BE2-412B-AB10-818BC8BCA43D}");
        public static readonly ID BarColour = new ID("{854A6E68-6A5E-4012-91E8-3B6EF4E144C6}");
        public static readonly ID WidthPercentage = new ID("{E79DD605-A5A2-4132-BF9E-364A1F7FD68C}");



      }
    }

    public static class AboutUs
    {
      public static class Fields
      {
        public static readonly ID LeftTitle = new ID("{92A6D3B4-8528-402A-9E63-17918D25381D}");
        public static readonly ID LeftText = new ID("{8CC10896-8266-4CFB-928A-6ED4A30ECBB9}");
        public static readonly ID LeftBottomTitle = new ID("{F88DDE3D-7DAD-4E42-B270-93BF173057A4}");
        public static readonly ID BottomList= new ID("{F2321EBC-D52B-4458-B404-16658A406ECD}");
        public static readonly ID RightTitle = new ID("{6882741B-8A24-457E-A92C-64A869DD3242}");
        public static readonly ID RightList = new ID("{B0C9BA5A-587D-410B-A2E0-6DA6C5F2EA54}");
        public static readonly ID RightBottomTitle = new ID("{A78FE078-350E-4C39-B1E4-7DBF54F4731B}");
        public static readonly ID RightBottomText= new ID("{A3C53C45-BB2A-4D4C-952E-A5CBDC11184F}");




      }
    }

    public static class Employee
    {
      public static class Fields
      {
        public static readonly ID Image = new ID("{E22330AB-C35C-4961-B7F8-10A380CB26B1}");
        public static readonly ID Name = new ID("{58300F4F-AF49-4C71-B866-C0C73C4CEB29}");
        public static readonly ID Presentation = new ID("{F5CDB1D9-28A8-437E-95AD-A240C47AC312}");
        public static readonly ID FacebookLink = new ID("{1FC299DA-512E-4B95-BCFF-3AEC660DABEB}");
        public static readonly ID GoogleLink = new ID("{12C0762C-66C4-4AC4-A7A2-C08FC58469F7}");
        public static readonly ID TwitterLink = new ID("{BD608EDD-41FD-4256-AD90-693312F4CA15}");
        public static readonly ID LinkedInLink = new ID("{3347945A-B598-451D-A891-B6F797A94E2E}");
      }
    }
    public static class CompanyTeam
        {
      public static class Fields
            {
        public static readonly ID Title = new ID("{BAF1819B-2C02-4E2E-8F35-530B8441BA81}");
        public static readonly ID EmployeeList = new ID("{C87A7A26-325B-49CB-953F-7777FAEFC473}");
      }
        }

    public static class ServiceComponent
    {
      public static class Fields
      {
        public static readonly ID Icon = new ID("{53A37D0E-6EE6-4167-92F9-1DBD722476C4}");
        public static readonly ID Title = new ID("{FE67AA35-44A4-439A-BF8A-A6262A175EDB}");
        public static readonly ID Text = new ID("{9BE39305-04C2-4903-BCA0-C58954488521}");

      }
    }

    public static class Services
    {
      public static class Fields
      {
        public static readonly ID ComponentList = new ID("{F9E39D74-6103-453D-A90B-433EE7A340BC}");
        public static readonly ID Text = new ID("{92ADF039-DC15-43BA-89CA-F1DBE6CF4D98}");
        public static readonly ID Link = new ID("{5EA3FD4E-002F-470A-85B6-BB6A2B289386}");

      }
    }

    public static class Portfolio
    {
      public static class Fields
      {
        public static readonly ID PhotoList = new ID("{7BD556F8-CDF9-4927-97A6-14431824630C}");
        

      }
    }

    public static class PortfolioImg
    {
      public static class Fields
      {
        public static readonly ID Image = new ID("{7FC65968-BCB0-4EF4-BE70-102BC0F9BD46}");
        public static readonly ID Title= new ID("{1D44D224-D096-4C66-9E18-2FF90145F01F}");
        public static readonly ID Description = new ID("{A7F324FE-526C-4792-BE03-3B6E1DFDEB26}");
      }
    }
    public static class Error404
    {
      public static class Fields
      {
        public static readonly ID Title = new ID("{AA4E341A-7FCA-44D9-BEAD-B728637C9644}");
        public static readonly ID Text = new ID("{9F3E3BF9-CB28-407A-B59E-DBF950C139CD}");
        public static readonly ID Link = new ID("{CC9F909C-277F-4FCF-B1AE-63A5BFAAA329}");


      }
    }

    public static class PrivacyPolicy
    {
      public static class Fields
      {
        public static readonly ID Title = new ID("{8511310B-368E-4277-95A9-378587044F6B}");
        public static readonly ID Text = new ID("{CADDED13-D79F-4409-9A22-C5281B6A2B0F}");
      


      }
    }
  }
}