using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using EPiServer;
using EPiServer.Core;

namespace Adage.EpiStarterKit.ModelPartials.BusObj
{
    public partial class SiteDataRepository : ISiteDataRepository
    {
        #region Class Variables
        protected readonly IContentRepository ContentRepository;

        #endregion

        #region Constructors
        public SiteDataRepository(IContentRepository contentRepository)
        {
            if (contentRepository == null)
            {
                throw new ArgumentNullException(nameof(contentRepository));
            }

            this.ContentRepository = contentRepository;
        }
        #endregion

        #region ISiteDataRepository Members
        public SiteSettingsPage SiteSettingsPage
        {
            get
            {
                var homePage = ContentRepository.Get<HomePage>(PageReference.StartPage);

                if (homePage == null || homePage.SiteSettingsPage == null)
                {
                    throw new ApplicationException("Site Settings page not configured. This is required for the site to work correctly.");
                }

                return ContentRepository.Get<SiteSettingsPage>(homePage.SiteSettingsPage);
            }
        }
        #endregion
    }
}
