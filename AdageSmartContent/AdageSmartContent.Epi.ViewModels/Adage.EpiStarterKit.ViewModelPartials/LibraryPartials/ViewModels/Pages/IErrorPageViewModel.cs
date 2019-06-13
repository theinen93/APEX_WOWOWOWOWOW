using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Pages
{
    public partial interface IErrorPageViewModel : IPageViewModel<ErrorPage>
    {
        int ErrorCode { get; }
        void SetErrorCode(int errorCode);
    }
}
