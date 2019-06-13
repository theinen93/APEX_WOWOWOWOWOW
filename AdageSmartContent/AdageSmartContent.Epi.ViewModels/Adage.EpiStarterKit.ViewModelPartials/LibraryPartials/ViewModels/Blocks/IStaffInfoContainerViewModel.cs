using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ViewModelPartials.Pocos;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks
{
    public partial interface IStaffInfoContainerViewModel : IBlockViewModel<StaffInfoContainerBlock>
    {
        /// <summary>
        /// The collection of items to be displayed in the container
        /// </summary>
        IEnumerable<StaffInfoViewItem> StaffInfoItems { get; }
    }
}
