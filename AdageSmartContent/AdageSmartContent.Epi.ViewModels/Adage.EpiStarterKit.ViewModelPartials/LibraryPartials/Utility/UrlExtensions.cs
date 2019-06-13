using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Routing;
using EPiServer.ServiceLocation;
using System.Web.Mvc;
using EPiServer.Web.Mvc.Html;
using System.Collections.Generic;
using EPiServer.Globalization;
using System.Web.Routing;
using System.Web;
using System.Linq;

namespace Adage.EpiStarterKit.ViewModelPartials.LibraryPartials.Utility
{
    public static class UrlExtensions
    {
        public static string GetFriendlyUrl(this Url url)
        {
            try
            {
                if (url == null || url.IsEmpty())
                    return string.Empty;
                var urlHelper = ServiceLocator.Current.GetInstance<UrlHelper>();
                return urlHelper.ContentUrl(url);
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string GetFriendlyUrl(this ContentReference contentReference, Dictionary<string, string> parameters = null)
        {
            try
            {

                if (contentReference == null) return string.Empty;

                var urlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();
                string language = ContentLanguage.PreferredCulture.Name;

                VirtualPathData contentUrl;
                if (parameters != null && parameters.Any())
                {
                    RouteValueDictionary routeParams = new RouteValueDictionary(parameters);
                    RequestContext currentRequest = HttpContext.Current.Request.RequestContext;
                    contentUrl = urlResolver.GetVirtualPath(contentReference, language, routeParams, currentRequest);
                }
                else
                {
                    contentUrl = urlResolver.GetVirtualPath(contentReference, language);
                }

                return contentUrl?.GetUrl() ?? string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
