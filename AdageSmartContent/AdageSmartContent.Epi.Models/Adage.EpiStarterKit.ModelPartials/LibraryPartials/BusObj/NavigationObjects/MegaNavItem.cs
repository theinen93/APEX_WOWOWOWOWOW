using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.BusObj.NavigationObjects
{
    public partial class MegaNavItem
    {
        /// <summary>
        /// True if the MegaNavItem is of type "Mega Nav Page"
        /// </summary>
        public bool IsMegaNavContainerPage { get; set; }
        /// <summary>
        /// PageData of the MegaNavItem
        /// </summary>
        public PageData NavPageData { get; set; }
        /// <summary>
        /// Children of the MegaNavItem page
        /// </summary>
        public IEnumerable<PageData> MegaNavChildren { get; set; }
    }
}
