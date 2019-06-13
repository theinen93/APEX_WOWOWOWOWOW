using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using EPiServer.DataAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks
{
    public partial class BaseLinkBlockViewModel<T> : BlockViewModel<T>, IBaseLinkBlockViewModel<T> where T : BaseLinkBlock
    {
        #region Class Variables
        protected readonly IFrameRepository FrameRepository;
        #endregion

        #region Constructors
        public BaseLinkBlockViewModel(T currentBlock, IFrameRepository frameRepository) : base(currentBlock)
        {
            if (frameRepository == null)
            {
                throw new ArgumentNullException(nameof(frameRepository));
            }

            this.FrameRepository = frameRepository;
        }
        #endregion

        #region IBaseLinkBlockViewModel Members
        public string CssClass { get; set; }

        public string TargetFrame
        {
            get
            {
                if (CurrentBlock.TargetFrameRaw.HasValue)
                {
                    var frame = FrameRepository.Load(CurrentBlock.TargetFrameRaw.Value);
                    return frame.Name;
                }

                return null;
            }
        }
        #endregion
    }
}
