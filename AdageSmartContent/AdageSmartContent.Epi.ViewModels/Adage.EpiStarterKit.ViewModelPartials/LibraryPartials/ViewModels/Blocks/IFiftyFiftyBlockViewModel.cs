using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Adage.EpiStarterKit.ViewModelPartials.LibraryPartials.Static.ViewModelEnums;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks
{
    public partial interface IFiftyFiftyBlockViewModel : IBlockViewModel<FiftyFiftyBlock>
    {
        /// <summary>
        /// Type of content for left tile of 5050 block
        /// </summary>
        FiftyFiftyContentType LeftContentType { get; }

        /// <summary>
        /// Type of content for right tile of 5050 block
        /// </summary>
        FiftyFiftyContentType RightContentType { get; }

        /// <summary>
        /// Determines if the right tile should be on top on mobile
        /// </summary>
        bool ReversedOnMobile { get; }


    }
}
