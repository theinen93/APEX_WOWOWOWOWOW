using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels
{
    public partial interface IViewModelFactory
    {
        object GetViewModel(Type viewType, Type modelType, object modelInstance = null);
    }
}
