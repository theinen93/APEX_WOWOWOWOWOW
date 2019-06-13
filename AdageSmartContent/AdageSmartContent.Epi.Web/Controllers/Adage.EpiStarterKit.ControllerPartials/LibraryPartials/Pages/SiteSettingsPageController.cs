using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Adage.EpiStarterKit.ControllerPartials.Base;
using Adage.EpiStarterKit.ModelPartials.BusObj;
using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels;
using Adage.EpiStarterKit.ViewModelPartials.BusObj;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace Adage.EpiStarterKit.ControllerPartials.Pages
{
    [TemplateDescriptor(ModelType = typeof(SiteSettingsPage))]
    public partial class SiteSettingsPageController : AdageBasePageController<SiteSettingsPage>
    {


        protected virtual string AdageViewsSharedRoot { get; } = "~/Views/AdageViews/Shared";
        protected virtual string ClientViewsSharedRoot { get; } = "~/Views/ClientViews/Shared";

        protected readonly IBreadcrumbService BreadcrumbService;
        protected readonly ISiteDataRepository SiteDataRepository;
        protected readonly ISiteNavigationRepository SiteNavigationRepository;

        public SiteSettingsPageController(ISiteDataRepository siteDataRepository, ISiteNavigationRepository siteNavigationRepository, IViewModelFactory viewModelFactory, IBreadcrumbService breadcrumbService)
            : base(viewModelFactory)
        {
            SiteDataRepository = siteDataRepository;
            SiteNavigationRepository = siteNavigationRepository;
            BreadcrumbService = breadcrumbService;
        }

        public ActionResult RenderBreadcrumbs(PageData currentPage)
        {
            string breadcrumbsViewName = "Breadcrumbs.cshtml";
            var breadcrumbList = BreadcrumbService.GetPageBreadcrumbs(currentPage);
            return GetViewForFile(breadcrumbsViewName, breadcrumbList);
        }

        public ActionResult RenderMegaNav()
        {
            string megaNavFileName = "MegaNav.cshtml";
            return GetViewForFile(megaNavFileName, SiteNavigationRepository);
        }

        public ActionResult RenderMegaNavMobile()
        {
            string megaNavFileName = "MegaNavMobile.cshtml";
            return GetViewForFile(megaNavFileName, SiteNavigationRepository);
        }

        public ActionResult RenderSearch()
        {
            string searchBarFileName = "SearchBar.cshtml";
            return GetViewForFile(searchBarFileName, SiteDataRepository);

        }

        public ActionResult RenderSearchMobile()
        {
            string searchBarMobileFileName = "SearchBarMobile.cshtml";
            return GetViewForFile(searchBarMobileFileName, SiteDataRepository);
        }

        private ActionResult GetViewForFile(string fileName, object model)
        {
            string clientViewLocation = $"{ClientViewsSharedRoot}/{fileName}";
            string adageViewLocation = $"{AdageViewsSharedRoot}/{fileName}";

            if (System.IO.File.Exists(Server.MapPath(clientViewLocation)))
            {
                return View(clientViewLocation, model);
            }
            else
            {
                return View(adageViewLocation, model);
            }
        }
    }
}