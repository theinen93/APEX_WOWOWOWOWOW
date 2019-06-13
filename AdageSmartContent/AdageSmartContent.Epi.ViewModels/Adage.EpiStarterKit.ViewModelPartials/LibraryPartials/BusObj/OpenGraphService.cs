using Adage.EpiStarterKit.ModelPartials.BusObj;
using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using EPiServer.Web.Routing;
using Adage.EpiStarterKit.ViewModelPartials.LibraryPartials.Utility;

namespace Adage.EpiStarterKit.ViewModelPartials.BusObj
{
    public partial class OpenGraphService : IOpenGraphService
    {
        protected readonly ISiteDataRepository SiteDataRepository;

        public OpenGraphService(ISiteDataRepository siteDataRepository)
        {
            if (siteDataRepository == null)
            {
                throw new ArgumentNullException(nameof(siteDataRepository));
            }

            this.SiteDataRepository = siteDataRepository;
        }

        public virtual string GetOGUrl(PageData currentPage)
        {
            return EPiServer.Web.SiteDefinition.Current.SiteUrl.ToString().TrimEnd('/') + currentPage.ContentLink.ToPageReference().GetFriendlyUrl();
        }

        public virtual string GetOGTitle(PageData currentPage)
        {
            if (currentPage is AdageBasePage)
                return (currentPage as AdageBasePage).SEOTitle;
            else
                return string.Empty;
        }

        public virtual string GetOGDescription(PageData currentPage)
        {
            if (currentPage is AdageBasePage)
                return (currentPage as AdageBasePage).OGDescription;
            else
                return string.Empty;
        }

        public virtual string GetOGImage(PageData currentPage)
        {
            if (currentPage is AdageBasePage)
            {
                var ogImageUrl = (currentPage as AdageBasePage).OGImage.GetFriendlyUrl();
                if (!string.IsNullOrEmpty(ogImageUrl))
                    return EPiServer.Web.SiteDefinition.Current.SiteUrl.ToString().TrimEnd('/') + ogImageUrl;
                else
                    return string.Empty;
            }
            else
                return string.Empty;
        }

        public virtual string GetFacebookAppId()
        {
            return SiteDataRepository.SiteSettingsPage.FacebookAppId;
        }
    }
}
