using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks
{
    public partial interface IVideoBlockViewModel : IBlockViewModel<VideoBlock>
    {
        /// <summary>
        /// Unique ID to be used for clientside purposes
        /// </summary>
        string ClientID { get; }
    }
}
