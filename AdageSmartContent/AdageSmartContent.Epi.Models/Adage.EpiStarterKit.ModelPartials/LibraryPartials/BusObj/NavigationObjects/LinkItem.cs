using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.BusObj.NavigationObjects
{
    /// <summary>
    /// Represents a link to displayed in a navigation
    /// </summary>
    public partial class LinkItem
    {
        /// <summary>
        /// The url of the link
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        /// The target for the link
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// The title of the link
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The text of the link
        /// </summary>
        public string LinkText { get; set; }

        /// <summary>
        /// Determines if link is active-used in breadcrumbs
        /// </summary>
        public bool Active { get; set; }

    }
}
