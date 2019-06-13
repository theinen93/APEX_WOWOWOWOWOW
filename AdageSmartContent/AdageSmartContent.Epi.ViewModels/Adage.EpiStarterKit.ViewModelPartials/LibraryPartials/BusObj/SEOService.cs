using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using EPiServer.Core;

namespace Adage.EpiStarterKit.ViewModelPartials.BusObj
{
    public partial class SEOService : ISEOService
    {
        public virtual string GetSEODescription(PageData currentPage)
        {
            if (currentPage is AdageBasePage)
                return (currentPage as AdageBasePage).SEODescription;
            else
                return string.Empty;
        }
        public virtual string GetSEOKeywords(PageData currentPage)
        {
            if (currentPage is AdageBasePage)
                return (currentPage as AdageBasePage).SEOKeywords;
            else
                return string.Empty;
        }
        public virtual string GetSEORobots(PageData currentPage)
        {
            if (currentPage is AdageBasePage)
                return (currentPage as AdageBasePage).SEORobots;
            else
                return string.Empty;
        }
        public virtual string GetScript(PageData currentPage)
        {
            if (currentPage is AdageBasePage)
                return (currentPage as AdageBasePage).Script;
            else
                return string.Empty;
        }
    }
}
