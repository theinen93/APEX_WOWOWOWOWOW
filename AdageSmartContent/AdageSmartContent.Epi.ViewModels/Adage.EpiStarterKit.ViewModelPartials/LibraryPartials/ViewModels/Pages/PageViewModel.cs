using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using System;
using Adage.EpiStarterKit.ModelPartials.BusObj;
using Adage.EpiStarterKit.ViewModelPartials.BusObj;
using EPiServer.Core;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Pages
{
    public partial class PageViewModel<T> : IPageViewModel<T> where T : PageData
    {
        #region Class Variables
        protected readonly IOpenGraphService OpenGraphService;
        protected readonly ISEOService SEOService;

        #endregion

        #region Constructors

        public PageViewModel(T currentPage, ISiteDataRepository siteDataRepository, IOpenGraphService openGraphService, ISEOService seoService)
        {
            if (siteDataRepository == null)
            {
                throw new ArgumentNullException(nameof(siteDataRepository));
            }

            if (openGraphService == null)
            {
                throw new ArgumentNullException(nameof(openGraphService));
            }

            this.CurrentPage = currentPage;
            this.SiteDataRepository = siteDataRepository;
            this.OpenGraphService = openGraphService;
            this.SEOService = seoService;
        }
        #endregion

        #region IPageViewModel Members
        public T CurrentPage { get; private set; }
        public ISiteDataRepository SiteDataRepository { get; private set; }

        public virtual string MetaTitle
        {
            get
            {
                if (CurrentPage is AdageBasePage && !string.IsNullOrEmpty((CurrentPage as AdageBasePage).SEOTitle))
                    return (CurrentPage as AdageBasePage).SEOTitle;
                else
                {
                    string siteName = EPiServer.Web.SiteDefinition.Current.Name;
                    string seoTitle = string.Format("{0} | {1}", siteName, CurrentPage.Name);
                    return seoTitle;
                }
            }
        }

        public virtual string OGUrl
        {
            get
            {
                return OpenGraphService.GetOGUrl(CurrentPage);
            }
        }

        public virtual string OGTitle
        {
            get
            {
                return OpenGraphService.GetOGTitle(CurrentPage);
            }
        }

        public virtual string OGDescription
        {
            get
            {
                return OpenGraphService.GetOGDescription(CurrentPage);
            }
        }

        public virtual string OGImage
        {
            get
            {
                return OpenGraphService.GetOGImage(CurrentPage);
            }
        }

        public virtual string FacebookAppId
        {
            get
            {
                return OpenGraphService.GetFacebookAppId();
            }
        }

        public virtual string SEODescription
        {
            get
            {
                return SEOService.GetSEODescription(CurrentPage);
            }
        }

        public virtual string SEOKeywords
        {
            get
            {
                return SEOService.GetSEOKeywords(CurrentPage);
            }
        }

        public virtual string SEORobots
        {
            get
            {
                return SEOService.GetSEORobots(CurrentPage);
            }
        }

        public virtual string Script
        {
            get
            {
                return SEOService.GetScript(CurrentPage);
            }
        }
        #endregion
    }
}
