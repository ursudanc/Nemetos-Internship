using Sitecon.Feature.PageContent.Models;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Diagnostics;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Sitecon.Feature.PageContent.Controllers
{
  public class PageContentController : Controller
  {
    public ActionResult ListWithIcons()
    {
      if (Sitecore.Context.Item == null)
      {
        return new EmptyResult();
      }
      var item = Sitecore.Context.Item;
      var multiLineTextString = item.Fields[Templates.ListWithIcons.Fields.ListText].Value;

      ListWithIconsItems listWithIconsItems = new ListWithIconsItems();
      listWithIconsItems.ListItems = new List<string>();

      if (string.IsNullOrEmpty(multiLineTextString))
      {
        return new EmptyResult();
      }
      string[] sep = new string[] { "\r\n" };
      string[] lines = multiLineTextString.Split(sep, StringSplitOptions.RemoveEmptyEntries);
      foreach (string listItem in lines)
      {
        if (!string.IsNullOrEmpty(listItem))
        {
          listWithIconsItems.ListItems.Add(listItem);
        }
      }
      listWithIconsItems.ListIcon = item.Fields[Templates.ListWithIcons.Fields.ListIcon].Value;
      return View(listWithIconsItems);
    }
    public ActionResult IndexPart1()
    {
      if (Sitecore.Context.Item == null)
      {
        return new EmptyResult();
      }
      var item = Sitecore.Context.Item;
      IndexPart1 part1 = new IndexPart1();
      // get title 
      part1.Title = item.Fields[Templates.IndexPart1.Fields.Title].Value;

      //get text
      part1.Text = item.Fields[Templates.IndexPart1.Fields.Text].Value;

      //get link
      LinkField Link = item.Fields[Templates.IndexPart1.Fields.Link];
      part1.Link = Link != null && Link.TargetItem != null
          ? Sitecore.Links.LinkManager.GetItemUrl(Link.TargetItem)
          : Link.Url;
      return View(part1);

    }

    public ActionResult FeaturedMainInfo()
    {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourceId = Sitecore.Context.Item.ID.ToString();
      Assert.IsNotNullOrEmpty(dataSourceId, "dataSourceId is null or empty");
      var item = Sitecore.Context.Database.GetItem(dataSourceId);

      FeaturedMainInfo featuredmaininfo = new FeaturedMainInfo();


      //Featured MainInfo List - TreeList Field
      MultilistField featuredmaininfoListField = item.Fields[Templates.FeaturedMainInfo.Fields.FeaturedMainInfoList];
      Item[] featuredMainInfoItems = featuredmaininfoListField.GetItems();
      List<MainInfo> featuredMainInfo = new List<MainInfo>();
      if (featuredMainInfoItems != null && featuredMainInfoItems.Count() > 0)
      {
        int x = 0;
        foreach (Item i in featuredMainInfoItems)
        {
          x++;
          MainInfo paragraph = new MainInfo();
          Item paragraphItem = Sitecore.Context.Database.GetItem(i.ID);
          // title
          paragraph.ParagraphTitle = paragraphItem.Fields[Templates.MainInfo.Fields.Title.ToString()].Value;

          //text
          paragraph.ParagraphText = paragraphItem.Fields[Templates.MainInfo.Fields.Text.ToString()].Value;

          //icon
          paragraph.ParagraphIcon = paragraphItem.Fields[Templates.MainInfo.Fields.ParagraphIcon].Value;
          paragraph.number = x;



          featuredMainInfo.Add(paragraph);
        }
      }

      featuredmaininfo.MainInfoList = featuredMainInfo;

      return View(featuredmaininfo);
    }
    public ActionResult MainWorkPhoto()
    {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourceId = Sitecore.Context.Item.ID.ToString();
      Assert.IsNotNullOrEmpty(dataSourceId, "dataSourceId is null or empty");
      var item = Sitecore.Context.Database.GetItem(dataSourceId);

      MainWorkPhoto mainWorkPhoto = new MainWorkPhoto();
      MultilistField mainWorkPhotoField = item.Fields[Templates.MainWorkPhotos.Fields.PhotosList];
      Item[] mainworkphotoItems = mainWorkPhotoField.GetItems();
      List<WorkPhoto> mainworkphoto = new List<WorkPhoto>();
      if (mainworkphotoItems != null && mainworkphotoItems.Count() > 0)
      {
        int x = 0;
        foreach (Item i in mainworkphotoItems)
        {
          x++;
          WorkPhoto Photo = new WorkPhoto();
          Item photoItem = Sitecore.Context.Database.GetItem(i.ID);

          // text
          Photo.WorkPhotoText = photoItem.Fields[Templates.WorkPhoto.Fields.Text.ToString()].Value;

          //image
          ImageField photoImage = photoItem.Fields[Templates.WorkPhoto.Fields.Image];
          Photo.WorkPhotoImageUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(photoImage.MediaItem);

          //image Full
          if (photoItem.Fields[Templates.WorkPhoto.Fields.ImageFull] != null)
          {
            ImageField photoImageFull = photoItem.Fields[Templates.WorkPhoto.Fields.ImageFull];
            Photo.WorkPhotoFullImageUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(photoImageFull.MediaItem);
          }

          Photo.number = x;

          mainworkphoto.Add(Photo);
        }

      }

      mainWorkPhoto.MainWorkPhotoList = mainworkphoto;

      return View(mainWorkPhoto);

    }

    public ActionResult Carousel()
    {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourceId = Sitecore.Context.Item.ID.ToString();
      Assert.IsNotNullOrEmpty(dataSourceId, "dataSourceId is null or empty");
      var item = Sitecore.Context.Database.GetItem(dataSourceId);
      Carousel carousel = new Carousel();

      //creating the list of carousel items
      MultilistField carouselField = item.Fields[Templates.Carousel.Fields.Items];
      Item[] carouselItems = carouselField.GetItems();
      List<CarouselItem> carouselList = new List<CarouselItem>();
      if (carouselItems != null && carouselItems.Count() > 0)
      {

        foreach (Item i in carouselItems)
        {

          CarouselItem carouselitem = new CarouselItem();
          // creating the list of carousel photos
          MultilistField carouselItemField = item.Fields[Templates.CarouselItem.Fields.ImageList];
          Item[] carouselItemItems = carouselItemField.GetItems();
          List<CarouselPhoto> carouselPhotoList = new List<CarouselPhoto>();
          if (carouselItemItems != null && carouselItemItems.Count() > 0)
          {
            foreach (Item photo in carouselItemItems)
            {
              CarouselPhoto carouselphoto = new CarouselPhoto();
              Item photoItem = Sitecore.Context.Database.GetItem(photo.ID);
              //image
              ImageField carouselImage = photoItem.Fields[Templates.CarouselPhoto.Fields.Image];
              MediaItem image = new MediaItem(carouselImage.MediaItem);
              carouselphoto.CarouselItemImageUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(image);
              carouselPhotoList.Add(carouselphoto);
            }
            //Item carouselItemo = Sitecore.Context.Database.GetItem(i.ID);


          }
          carouselitem.CarouselItemList = carouselPhotoList;

          carouselList.Add(carouselitem);
        }

      }
      carousel.CarouselList = carouselList;
      return View(carousel);

    }

    public ActionResult AboutUs()
    {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourceId = Sitecore.Context.Item.ID.ToString();
      Assert.IsNotNullOrEmpty(dataSourceId, "dataSourceId is null or empty");
      var item = Sitecore.Context.Database.GetItem(dataSourceId);
      AboutUs aboutUs = new AboutUs();

      //get Left title 
      aboutUs.LeftTitle = item.Fields[Templates.AboutUs.Fields.LeftTitle.ToString()].Value;

      //get Left text
      aboutUs.LeftText = item.Fields[Templates.AboutUs.Fields.LeftText.ToString()].Value;

      //get  Left Bottom Title
      aboutUs.LeftBottomTitle = item.Fields[Templates.AboutUs.Fields.LeftBottomTitle.ToString()].Value;

      //get Bottom List
      MultilistField aboutUsBottomListField = item.Fields[Templates.AboutUs.Fields.BottomList];
      Item[] aboutUsItems = aboutUsBottomListField.GetItems();
      List<Bar> aboutUsBottomList = new List<Bar>();
      if (aboutUsItems != null && aboutUsItems.Count() > 0)
      {
        foreach (Item i in aboutUsItems)
        {

          Bar bar = new Bar();
          Item barItem = Sitecore.Context.Database.GetItem(i.ID);

          // title
          bar.Title = barItem.Fields[Templates.Bar.Fields.Title.ToString()].Value;

          //bar colour
          bar.BarColour = barItem.Fields[Templates.Bar.Fields.BarColour].Value;

          //width percentage
          bar.WidthPercentage = barItem.Fields[Templates.Bar.Fields.WidthPercentage.ToString()].Value;

          aboutUsBottomList.Add(bar);

        }
      }
      aboutUs.BottomList = aboutUsBottomList;

      //get Right title 
      aboutUs.RightTitle = item.Fields[Templates.AboutUs.Fields.RightTitle.ToString()].Value;

      //get Right Bottom Title 
      aboutUs.RightBottomTitle = item.Fields[Templates.AboutUs.Fields.RightBottomTitle.ToString()].Value;

      //get Right Bottom Text
      aboutUs.RightBottomText = item.Fields[Templates.AboutUs.Fields.RightBottomText.ToString()].Value;

      //get Right List

      //string of number in words
      string[] words = new string[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

      MultilistField aboutUsRightListField = item.Fields[Templates.AboutUs.Fields.RightList];
      Item[] aboutUsItemsList = aboutUsRightListField.GetItems();
      List<AboutUsText> RightList = new List<AboutUsText>();
      int nr = 0;
      if (aboutUsItemsList != null && aboutUsItemsList.Count() > 0)
      {
        foreach (Item x in aboutUsItemsList)
        {
          AboutUsText aboutUsText = new AboutUsText();
          Item AboutUsTextItem = Sitecore.Context.Database.GetItem(x.ID);

          // title
          aboutUsText.Title = AboutUsTextItem.Fields[Templates.AboutUsText.Fields.Title.ToString()].Value;


          // text
          aboutUsText.Text = AboutUsTextItem.Fields[Templates.AboutUsText.Fields.Text.ToString()].Value;

          //number
          nr++;
          aboutUsText.href = "#collapse" + words[nr];
          aboutUsText.id = "collapse" + words[nr];

          RightList.Add(aboutUsText);

        }
      }
      aboutUs.RightList = RightList;

      return View(aboutUs);



    }

    public ActionResult CompanyTeam()
    {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourceId = Sitecore.Context.Item.ID.ToString();
      Assert.IsNotNullOrEmpty(dataSourceId, "dataSourceId is null or empty");
      var item = Sitecore.Context.Database.GetItem(dataSourceId);

      CompanyTeam company = new CompanyTeam();

      //get  Title 
      company.Title = item.Fields[Templates.CompanyTeam.Fields.Title.ToString()].Value;

      //get the Employee List
      MultilistField EmployeeListField = item.Fields[Templates.CompanyTeam.Fields.EmployeeList];
      Item[] EmployeeItems = EmployeeListField.GetItems();
      List<Employee> employees = new List<Employee>();
      if (EmployeeItems != null && EmployeeItems.Count() > 0)
      {
        foreach (Item i in EmployeeItems)
        {
          Employee employee = new Employee();
          Item employeeItem = Sitecore.Context.Database.GetItem(i.ID);

          //image
          ImageField Image = employeeItem.Fields[Templates.Employee.Fields.Image];
          employee.ImageUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(Image.MediaItem);

          // Name
          employee.Name = employeeItem.Fields[Templates.Employee.Fields.Name.ToString()].Value;

          // Presentation
          employee.Presentation = employeeItem.Fields[Templates.Employee.Fields.Presentation.ToString()].Value;

          // get FacebookLink
          LinkField FacebookLink = employeeItem.Fields[Templates.Employee.Fields.FacebookLink];
          employee.FacebookLink = FacebookLink.Url;

          // get GooglekLink
          LinkField GoogleLink = employeeItem.Fields[Templates.Employee.Fields.GoogleLink];
          employee.GoogleLink = GoogleLink.Url;

          // get TwitterLink
          LinkField TwitterLink = employeeItem.Fields[Templates.Employee.Fields.TwitterLink];
          employee.TwitterLink = TwitterLink.Url;

          // get LinkedInLink
          LinkField LinkedInLink = employeeItem.Fields[Templates.Employee.Fields.LinkedInLink];
          employee.LinkedInLink = LinkedInLink.Url;

          employees.Add(employee);
        }

      }
      company.EmployeesList = employees;
      return View(company);


    }

    public ActionResult Services()
    {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourceId = Sitecore.Context.Item.ID.ToString();
      Assert.IsNotNullOrEmpty(dataSourceId, "dataSourceId is null or empty");
      var item = Sitecore.Context.Database.GetItem(dataSourceId);

      Services services = new Services();

      //get  Text
      services.Text = item.Fields[Templates.Services.Fields.Text.ToString()].Value;

      //get Link
      LinkField Link = item.Fields[Templates.Services.Fields.Link];
      services.Link = Link.Url;

      //get list
      MultilistField ComponentListField = item.Fields[Templates.Services.Fields.ComponentList];
      Item[] ComponentItems = ComponentListField.GetItems();
      List<ServiceComponent> serviceComponents = new List<ServiceComponent>();
      int x = 0;
      if (ComponentItems != null && ComponentItems.Count() > 0)
      {
        foreach (Item i in ComponentItems)
        {
          ServiceComponent serviceComponent = new ServiceComponent();
          Item serviceItem = Sitecore.Context.Database.GetItem(i.ID);
          //Icon
          serviceComponent.Icon = serviceItem.Fields[Templates.ServiceComponent.Fields.Icon].Value;
          //Text
          serviceComponent.Text = serviceItem.Fields[Templates.ServiceComponent.Fields.Text.ToString()].Value;
          //Title
          serviceComponent.Title = serviceItem.Fields[Templates.ServiceComponent.Fields.Title.ToString()].Value;
          x++;
          serviceComponent.nr = x;
          serviceComponents.Add(serviceComponent);
          

        }

      }
      services.ComponentList = serviceComponents;

      return View(services);
    }
    public ActionResult Portfolio()
    {

      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourceId = Sitecore.Context.Item.ID.ToString();
      Assert.IsNotNullOrEmpty(dataSourceId, "dataSourceId is null or empty");
      var item = Sitecore.Context.Database.GetItem(dataSourceId);
      Portfolio portfolio = new Portfolio();
      //get list

      MultilistField PhotoListField = item.Fields[Templates.Portfolio.Fields.PhotoList];
      Item[] PortfolioItems = PhotoListField.GetItems();
      List<PortfolioImg> photoList = new List<PortfolioImg>();
      int x = 0;
      if (PortfolioItems != null && PortfolioItems.Count() > 0)
      { 
        foreach( Item i in PortfolioItems)
                {
          PortfolioImg portfolioImg = new PortfolioImg();
          Item portfolioItem = Sitecore.Context.Database.GetItem(i.ID);

          //image
          ImageField Image = portfolioItem.Fields[Templates.PortfolioImg.Fields.Image];
          portfolioImg.ImageUrl = Sitecore.Resources.Media.MediaManager.GetMediaUrl(Image.MediaItem);

          // Name
          portfolioImg.Title = portfolioItem.Fields[Templates.PortfolioImg.Fields.Title.ToString()].Value;

          // Name
          portfolioImg.Description = portfolioItem.Fields[Templates.PortfolioImg.Fields.Description.ToString()].Value;
          x++;
          portfolioImg.number = x;
          photoList.Add(portfolioImg);

        }

      }
      portfolio.PhotoList = photoList;
      return View(portfolio);

    }
    public ActionResult Error404()
        {
      if (Sitecore.Context.Item == null)
      {
        return null;
      }

      var dataSourceId = Sitecore.Context.Item.ID.ToString();
      Assert.IsNotNullOrEmpty(dataSourceId, "dataSourceId is null or empty");
      var item = Sitecore.Context.Database.GetItem(dataSourceId);
      Error404 error = new Error404();

      // Name
      error.Title= item.Fields[Templates.Error404.Fields.Title.ToString()].Value;

      // Text
      error.Text = item.Fields[Templates.Error404.Fields.Text.ToString()].Value;

      //Link
      LinkField Linku = item.Fields[Templates.Error404.Fields.Link];
      error.Link = Linku.Url;
      return View(error);
    }
  }
}
