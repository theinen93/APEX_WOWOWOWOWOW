using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels.Pages;
using EPiServer;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using EPiServer.Core;

namespace Adage.EpiStarterKit.ControllerPartials.Base
{
    public partial class AdageBasePageController<T> : PageController<T> where T : PageData
    {
        protected IViewModelFactory ViewModelFactory { get; set; }

        protected virtual string RootFileName { get; } = "{0}/{1}View.cshtml";
        protected virtual string AdageViewsRoot { get; } = "~/Views/AdageViews/Pages";
        protected virtual string ClientViewsRoot { get; } = "~/Views/ClientViews/Pages";

        protected virtual T CurrentPage
        {
            get
            {
                return this.PageContext.Page as T;
            }
        }

        public AdageBasePageController(IViewModelFactory viewModelFactory)
        {
            this.ViewModelFactory = viewModelFactory;
        }

        /// <summary>
        /// Index Method of the controller
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        public virtual ActionResult Index(T currentPage)
        {
            var model = CreateDefaultPageViewModel(currentPage);
            return View(GetViewLocation(currentPage), model);
        }

        protected virtual object CreateDefaultPageViewModel<U>(U page)
        {
            var type = typeof(IPageViewModel<>).MakeGenericType(page.GetOriginalType());
            var modelType = page.GetOriginalType();
            return ViewModelFactory.GetViewModel(type, modelType, page);
        }

        /// <summary>
        /// Creates the IPageViewModel<> for the page using a view model factory.
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        protected virtual V CreatePageViewModel<V>(T page) where V : class
        {
            var viewType = typeof(V);
            var modelType = typeof(T);
            var viewModel = ViewModelFactory.GetViewModel(viewType, modelType, page);
            return viewModel as V;
        }

        protected virtual string GetViewLocation(T currentPage)
        {
            string adageViewLocation = string.Format(RootFileName, AdageViewsRoot, currentPage.PageTypeName);
            string clientViewLocation = string.Format(RootFileName, ClientViewsRoot, currentPage.PageTypeName);
            if (System.IO.File.Exists(Server.MapPath(clientViewLocation)))
                return clientViewLocation;
            else
                return adageViewLocation;
        }
    }
}