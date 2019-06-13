using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks
{
    public partial interface IBaseLinkBlockViewModel<out T> : IBlockViewModel<T> where T : BaseLinkBlock
    {
        /// <summary>
        /// The value of the target attribute for this link
        /// </summary>
        string TargetFrame { get; }

        /// <summary>
        /// Css class to apply to the anchor tag
        /// </summary>
        string CssClass { get; set; }
    }
}
