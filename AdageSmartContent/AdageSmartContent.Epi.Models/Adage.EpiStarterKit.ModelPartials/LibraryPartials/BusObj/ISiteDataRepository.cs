using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.BusObj
{
    /// <summary>
    /// Responsible for instances of typed page data objects which are critical for site logic
    /// </summary>
    public partial interface ISiteDataRepository
    {
        /// <summary>
        /// The site configuration page
        /// </summary>
        SiteSettingsPage SiteSettingsPage { get; }

    }
}
