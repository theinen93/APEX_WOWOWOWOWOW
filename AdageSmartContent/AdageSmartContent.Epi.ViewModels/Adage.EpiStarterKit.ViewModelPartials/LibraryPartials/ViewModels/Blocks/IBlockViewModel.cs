using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks
{
    public partial interface IBlockViewModel<out T> where T : AdageBaseBlock
    {
        T CurrentBlock { get; }
    }
}
