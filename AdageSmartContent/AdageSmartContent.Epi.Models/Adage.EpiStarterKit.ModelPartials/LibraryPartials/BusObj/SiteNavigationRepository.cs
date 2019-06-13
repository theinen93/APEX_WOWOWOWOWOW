using Adage.EpiStarterKit.ModelPartials.BusObj;
using Adage.EpiStarterKit.ModelPartials.BusObj.NavigationObjects;
using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using EPiServer;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.BusObj
{
    public partial class SiteNavigationRepository : ISiteNavigationRepository
    {
        protected ISiteDataRepository SiteDataRepository { get; set; }
        protected IContentRepository ContentRepository { get; set; }


        #region Constructors
        public SiteNavigationRepository(ISiteDataRepository siteDataRepository, IContentRepository contentRepository)
        {
            SiteDataRepository = siteDataRepository;
            ContentRepository = contentRepository;
        }
        #endregion

        #region ISiteNavigationRepository Members
        private IEnumerable<MegaNavItem> _megaNavItems { get; set; }

        public IEnumerable<MegaNavItem> MegaNavItems
        {
            get
            {
                if (_megaNavItems == null || !_megaNavItems.Any())
                {
                    List<MegaNavItem> navItems = new List<MegaNavItem>();
                    foreach (var megaNavItem in this.MegaNavItemsCollection)
                    {
                        bool isMegaNavContainerPage = megaNavItem is MegaNavPage;
                        MegaNavItem navItem = new MegaNavItem
                        {
                            IsMegaNavContainerPage = isMegaNavContainerPage,
                            MegaNavChildren = isMegaNavContainerPage ? ContentRepository.GetChildren<PageData>(megaNavItem.ContentLink)?.Where(page => page.VisibleInMenu) : null,
                            NavPageData = megaNavItem
                        };
                        navItems.Add(navItem);
                    }
                    _megaNavItems = navItems;
                }
                return _megaNavItems;
            }
        }

        private List<LinkItem> _utilityNavLinks;
        public IEnumerable<LinkItem> UtilityNavLinks
        {
            get
            {
                if (_utilityNavLinks == null)
                {
                    _utilityNavLinks = new List<LinkItem>();

                    if (SiteDataRepository.SiteSettingsPage.UtilityNavLinks != null)
                    {
                        foreach (var epiLinkItem in SiteDataRepository.SiteSettingsPage.UtilityNavLinks)
                        {
                            var linkItem = new LinkItem
                            {
                                Href = epiLinkItem.Href,
                                Target = epiLinkItem.Target,
                                Title = epiLinkItem.Title,
                                LinkText = epiLinkItem.Text
                            };

                            _utilityNavLinks.Add(linkItem);
                        }
                    }
                }

                return _utilityNavLinks;
            }
        }
        #endregion

        private IEnumerable<PageData> _megaNavItemsCollection;
        private IEnumerable<PageData> MegaNavItemsCollection
        {
            get
            {
                if (_megaNavItemsCollection == null)
                {
                    _megaNavItemsCollection = ContentRepository.GetChildren<PageData>(PageReference.StartPage).Where(pd => pd.VisibleInMenu);
                }
                return _megaNavItemsCollection;
            }
        }
    }
}
