using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks
{
    public partial class BlockViewModel<T> : IBlockViewModel<T> where T : AdageBaseBlock
    {
        public BlockViewModel(T currentBlock)
        {
            CurrentBlock = currentBlock;
        }

        public T CurrentBlock { get; private set; }
    }
}
