using Adage.EpiStarterKit.ModelPartials.BusObj.NavigationObjects;
using Adage.EpiStarterKit.ViewModelPartials.LibraryPartials.Utility;
using EPiServer;
using EPiServer.Core;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.BusObj
{
    public partial class BreadcrumbService : IBreadcrumbService
    {
        protected readonly IContentLoader ContentLoader;

        public BreadcrumbService(IContentLoader contentLoader)
        {
            if (contentLoader == null)
            {
                throw new ArgumentNullException(nameof(contentLoader));
            }

            this.ContentLoader = contentLoader;
        }

        public virtual List<LinkItem> GetPageBreadcrumbs(PageData currentPage)
        {
            List<LinkItem> linkItems = new List<LinkItem>();

            var parents = ContentLoader.GetAncestors(currentPage.ContentLink)
                .Reverse()
                .Cast<PageData>()
                .Where(p => p.ContentLink != PageReference.RootPage);

            if (parents != null)
            {
                foreach (var parent in parents)
                {
                    var linkItem = new LinkItem
                    {
                        Href = parent.ContentLink.GetFriendlyUrl(),
                        Title = parent.Name,
                        LinkText = parent.Name,
                        Active = true
                    };
                    linkItems.Add(linkItem);
                }
            }

            linkItems.Add(new LinkItem
            {
                Href = currentPage.ContentLink.GetFriendlyUrl(),
                Title = currentPage.Name,
                LinkText = currentPage.Name,
                Active = false
            });

            return linkItems;

        }
    }
}
