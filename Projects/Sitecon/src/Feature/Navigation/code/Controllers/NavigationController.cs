using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Sitecon.Feature.Navigation.Models;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;

namespace Sitecon.Feature.Navigation.Controllers
{
  public class NavigationController : Controller
  {
    public ActionResult Header()
    {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
      if (string.IsNullOrEmpty(dataSourceId))
      {
        return null;
      }
      var item = Sitecore.Context.Database.GetItem(dataSourceId);
      if (item == null)
      {
        return null;
      }

      Header header = new Header();

      //Image Field
      ImageField logo = item.Fields[Templates.Header.Fields.Logo];
      if (logo != null && logo.MediaItem != null)
      {
        MediaItem image = new MediaItem(logo.MediaItem);
        header.ImageUrl = Sitecore.StringUtil.EnsurePrefix('/', Sitecore.Resources.Media.MediaManager.GetMediaUrl(image));
        header.ImageAlt = image.Alt;
      }

      //Home Link - Droplink Field
      ReferenceField homeLink = item.Fields[Templates.Header.Fields.HomeLink];
      header.HomeLinkUrl = homeLink != null
        ? Sitecore.Links.LinkManager.GetItemUrl(homeLink.TargetItem)
        : string.Empty;

      //Event Links - DropTree Field with Child Items
      ReferenceField eventsRoot = item.Fields[Templates.Header.Fields.EventsRoot];
      header.Events = new List<NavigationItem>();
      foreach (Item i in eventsRoot.TargetItem.Children)
      {
        var navigationItem = new NavigationItem();
        navigationItem.Item = i;
        navigationItem.ItemUrl = i != null
          ? Sitecore.Links.LinkManager.GetItemUrl(i)
          : string.Empty;

        header.Events.Add(navigationItem);
      }

      //Schedule Link - General Link with Anchor Tag
      LinkField scheduleLink = item.Fields[Templates.Header.Fields.ScheduleLink];
      header.ScheduleLinkUrl = scheduleLink != null
        ? string.Format("{0}#{1}", Sitecore.Links.LinkManager.GetItemUrl(scheduleLink.TargetItem), scheduleLink.Anchor)
        : string.Empty;

      return View(header);
    }

    public ActionResult Footer()
    {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
      if (string.IsNullOrEmpty(dataSourceId))
      {
        return null;
      }
      var item = Sitecore.Context.Database.GetItem(dataSourceId);
      if (item == null)
      {
        return null;
      }

      Footer footer = new Footer();

      //Left Text
      footer.FooterTextLeft = item.Fields[Templates.Footer.Fields.FooterTextLeft].Value;

      //Left Link - General Link with Search Field
      LinkField leftLink = item.Fields[Templates.Footer.Fields.FooterLinkLeft];
      footer.FooterLinkUrlLeft = leftLink != null && leftLink.TargetItem != null
        ? string.Format("{0}#{1}", Sitecore.Links.LinkManager.GetItemUrl(leftLink.TargetItem), leftLink.Anchor)
        : string.Empty;
      footer.FooterLinkTargetLeft = leftLink.Target;
      footer.FooterLinkTextLeft = item.Fields[Templates.Footer.Fields.FooterLinkTextLeft].Value;

      //Right Text
      footer.FooterTextRight = item.Fields[Templates.Footer.Fields.FooterTextRight].Value;

      //Right Link - General Link Field
      LinkField rightLink = item.Fields[Templates.Footer.Fields.FooterLinkRight];
      footer.FooterLinkUrlRight = rightLink != null && rightLink.TargetItem != null
          ? Sitecore.Links.LinkManager.GetItemUrl(rightLink.TargetItem)
          : rightLink.Url;
      footer.FooterLinkTargetRight = rightLink.Target;
      footer.FooterLinkTextRight = item.Fields[Templates.Footer.Fields.FooterLinkTextRight].Value;

      return View(footer);
    }


    public ActionResult Navbar()
    {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourceId = RenderingContext.CurrentOrNull.Rendering.DataSource;
      if (string.IsNullOrEmpty(dataSourceId))
      {
        return null;
      }
      var item = Sitecore.Context.Database.GetItem(dataSourceId);
      if (item == null)
      {
        return null;
      }

      Navbar navbar = new Navbar();

      //Image Field
      ImageField logo = item.Fields[Templates.Navbar.Fields.Logo];
      if (logo != null && logo.MediaItem != null)
      {
        MediaItem image = new MediaItem(logo.MediaItem);
        navbar.ImageUrl = Sitecore.StringUtil.EnsurePrefix('/', Sitecore.Resources.Media.MediaManager.GetMediaUrl(image));
        navbar.ImageAlt = image.Alt;
      }

      //Home Link - General Link with Search
      LinkField HomeLink = item.Fields[Templates.Navbar.Fields.HomeLink];
      navbar.HomeLinkUrl = HomeLink!= null
        ? string.Format("{0}#{1}", Sitecore.Links.LinkManager.GetItemUrl(HomeLink.TargetItem), HomeLink.Anchor)
        : string.Empty;


      //About Us Link - General Link with Search
      LinkField AboutUsLink = item.Fields[Templates.Navbar.Fields.AboutUs];
      navbar.AboutUsLinkUrl = AboutUsLink != null
        ? string.Format("{0}#{1}", Sitecore.Links.LinkManager.GetItemUrl(AboutUsLink.TargetItem), AboutUsLink.Anchor)
        : string.Empty;

      //Services Link - General Link with Search
      LinkField ServicesLink = item.Fields[Templates.Navbar.Fields.Services];
      navbar.ServicesLinkUrl = ServicesLink != null
        ? string.Format("{0}#{1}", Sitecore.Links.LinkManager.GetItemUrl(ServicesLink.TargetItem), ServicesLink.Anchor)
        : string.Empty;
      
      //Portfolio Link - General Link with Search
      LinkField  PortfolioLink = item.Fields[Templates.Navbar.Fields.Portflio];
      navbar.PortfolioLinkUrl = PortfolioLink != null
        ? string.Format("{0}#{1}", Sitecore.Links.LinkManager.GetItemUrl(PortfolioLink.TargetItem), PortfolioLink.Anchor)
        : string.Empty;
      
      //Error 404 Link - General Link with Search
      LinkField Error404Link = item.Fields[Templates.Navbar.Fields.Error404];
      navbar.Error404LinkUrl = Error404Link != null
        ? string.Format("{0}#{1}", Sitecore.Links.LinkManager.GetItemUrl(Error404Link.TargetItem), Error404Link.Anchor)
        : string.Empty;

      //Privacy Policy Link - General Link with Search
      LinkField PrivacyPolicyLink = item.Fields[Templates.Navbar.Fields.PrivacyPolicy];
      navbar.PrivacyPolicyLinkUrl = PrivacyPolicyLink != null
        ? string.Format("{0}#{1}", Sitecore.Links.LinkManager.GetItemUrl(PrivacyPolicyLink.TargetItem), PrivacyPolicyLink.Anchor)
        : string.Empty;

      //Contact Link - General Link with Search
      LinkField ContactLink = item.Fields[Templates.Navbar.Fields.Contact];
      navbar.ContactLinkUrl = ContactLink != null
        ? string.Format("{0}#{1}", Sitecore.Links.LinkManager.GetItemUrl(ContactLink.TargetItem), ContactLink.Anchor)
        : string.Empty;

      return View(navbar);
    }

    public ActionResult PageTitle()
        {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourceId = Sitecore.Context.Item.ID.ToString();
      Assert.IsNotNullOrEmpty(dataSourceId, "dataSourceId is null or empty");
      var item = Sitecore.Context.Database.GetItem(dataSourceId);
      PageTitle pagetitle = new PageTitle();
      //Title of the page
      pagetitle.Title = item.Fields[Templates.PageTitle.Fields.Title].Value;

      // HomeLink with search
      LinkField homeLink = item.Fields[Templates.PageTitle.Fields.HomeLink];
      pagetitle.HomeLink = homeLink != null && homeLink.TargetItem != null
          ? Sitecore.Links.LinkManager.GetItemUrl(homeLink.TargetItem)
          : homeLink.Url;

      return View(pagetitle);

    }

  }
}
