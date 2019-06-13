using Adage.EpiStarterKit.ModelPartials.BusObj;
using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Pages
{
    public partial interface IPageViewModel<out T> where T : PageData
    {
        /// <summary>
        /// The site data repository
        /// </summary>
        ISiteDataRepository SiteDataRepository { get; }

        /// <summary>
        /// The current PageData object
        /// </summary>
        T CurrentPage { get; }

        /// <summary>
        /// The rendered SEO Title
        /// </summary>
        string MetaTitle { get; }

        /// <summary>
        /// The Open Graph Url
        /// </summary>
        string OGUrl { get; }
        /// <summary>
        /// The Open Graph Title
        /// </summary>
        string OGTitle { get; }
        /// <summary>
        /// The Open Graph Description
        /// </summary>
        string OGDescription { get; }
        /// <summary>
        /// The Open Graph Image Url
        /// </summary>
        string OGImage { get; }
        /// <summary>
        /// The Facebook App Id
        /// </summary>
        string FacebookAppId { get; }
        /// <summary>
        /// The SEO Description
        /// </summary>
        string SEODescription { get; }
        /// <summary>
        /// The SEO Keywords
        /// </summary>
        string SEOKeywords { get; }
        /// <summary>
        /// The SEO Robots Content
        /// </summary>
        string SEORobots { get; }
        /// <summary>
        /// Scripts for the HTML Header
        /// </summary>
        string Script { get; }
    }
}
