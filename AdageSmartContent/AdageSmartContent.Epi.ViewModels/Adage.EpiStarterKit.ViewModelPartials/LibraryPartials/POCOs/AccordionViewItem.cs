using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.Pocos
{
    public partial class AccordionViewItem
    {
        /// <summary>
        /// Unique ID to be used for clientside purposes
        /// </summary>
        public string ClientID { get; set; }

        /// <summary>
        /// The title to be displayed in the accordion
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Content revealed when a user clicks on the accordion
        /// </summary>
        public XhtmlString Content { get; set; }
    }
}
