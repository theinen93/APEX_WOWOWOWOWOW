using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.BusObj
{
    public partial interface ISEOService
    {
        /// <summary>
        /// Gets the SEO Description value
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        string GetSEODescription(PageData currentPage);

        /// <summary>
        /// Gets the SEO Keywords value
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        string GetSEOKeywords(PageData currentPage);

        /// <summary>
        /// Gets the SEO Robots value
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        string GetSEORobots(PageData currentPage);

        /// <summary>
        /// Gets the Script value
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        string GetScript(PageData currentPage);
    }
}
