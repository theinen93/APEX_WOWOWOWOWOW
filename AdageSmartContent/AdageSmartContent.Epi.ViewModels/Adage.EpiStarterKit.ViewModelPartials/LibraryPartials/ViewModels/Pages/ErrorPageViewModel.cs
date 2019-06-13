using Adage.EpiStarterKit.ModelPartials.BusObj;
using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using Adage.EpiStarterKit.ViewModelPartials.BusObj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Pages
{
    public partial class ErrorPageViewModel : PageViewModel<ErrorPage>, IErrorPageViewModel
    {
        private int _errorCode;
        public int ErrorCode
        {
            get
            {
                return _errorCode;
            }
        }

        public ErrorPageViewModel(ErrorPage currentPage, ISiteDataRepository siteDataRepository, IOpenGraphService openGraphService, ISEOService seoService) : base(currentPage, siteDataRepository, openGraphService, seoService)
        {
        }

        public void SetErrorCode(int errorCode)
        {
            _errorCode = errorCode;
        }
    }
}
