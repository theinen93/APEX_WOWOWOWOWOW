using Adage.EpiStarterKit.ModelPartials.BusObj.NavigationObjects;
using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.BusObj
{
    public partial interface ISiteNavigationRepository
    {
        /// <summary>
        /// The collection of top-level MegaNav Items
        /// </summary>
        IEnumerable<MegaNavItem> MegaNavItems { get; }

        /// <summary>
        /// The collection of utility nav items
        /// </summary>
        IEnumerable<LinkItem> UtilityNavLinks { get; }
    }
}
