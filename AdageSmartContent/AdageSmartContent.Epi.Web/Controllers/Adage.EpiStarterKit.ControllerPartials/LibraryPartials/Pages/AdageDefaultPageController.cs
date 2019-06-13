using Adage.EpiStarterKit.ControllerPartials.Base;
using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adage.EpiStarterKit.ControllerPartials.Pages
{
    public partial class AdageDefaultPageController : AdageBasePageController<PageData>
    {
        public AdageDefaultPageController(IViewModelFactory viewModelFactory) : base(viewModelFactory)
        {
        }
    }
}