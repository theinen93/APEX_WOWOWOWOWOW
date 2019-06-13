using Adage.EpiStarterKit.ModelPartials.BusObj.NavigationObjects;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.BusObj
{
    public partial interface IBreadcrumbService
    {
        /// <summary>
        /// Method to get bredcrumbs for current page 
        /// </summary>
        /// <param name="CurrentPage"></param>
        /// <returns>List of LinkItems for each page above it in page tree</returns>
        List<LinkItem> GetPageBreadcrumbs(PageData CurrentPage);
    }
}
