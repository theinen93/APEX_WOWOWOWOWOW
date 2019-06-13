using Adage.EpiStarterKit.ControllerPartials.Base;
using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adage.EpiStarterKit.ControllerPartials.Blocks
{
    public partial class AdageDefaultBlockController : AdageBaseBlockController<AdageBaseBlock>
    {
        public AdageDefaultBlockController(IViewModelFactory viewModelFactory) : base(viewModelFactory)
        {
        }
    }
}