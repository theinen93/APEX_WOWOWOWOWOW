using EPiServer;
using EPiServer.Core;

namespace Adage.EpiStarterKit.ViewModelPartials.BusObj
{
    /// <summary>
    /// An interface to get Open Graph tags used for social media sharing
    /// </summary>
    public partial interface IOpenGraphService
    {
        /// <summary>
        /// Gets the og:image value
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        string GetOGImage(PageData currentPage);

        /// <summary>
        /// Gets the og:title value
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        string GetOGTitle(PageData currentPage);

        /// <summary>
        /// Gets the og:description value
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        string GetOGDescription(PageData currentPage);

        /// <summary>
        /// Get the fb:app_id value
        /// </summary>
        /// <returns></returns>
        string GetFacebookAppId();

        /// <summary>
        /// Gets the og:url value
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        string GetOGUrl(PageData currentPage);
    }
}