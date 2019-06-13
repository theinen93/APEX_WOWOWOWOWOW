using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks
{
    public partial class VideoBlockViewModel : BlockViewModel<VideoBlock>, IVideoBlockViewModel
    {
        #region Constructors
        public VideoBlockViewModel(VideoBlock currentBlock) : base(currentBlock)
        {
        }
        #endregion


        #region IVideoBlockViewModel Members
        protected string _clientID;
        public string ClientID
        {
            get
            {
                if (_clientID == null)
                {
                    _clientID = "modal-" + Guid.NewGuid().ToString();
                }

                return _clientID;
            }
        }
        #endregion
    }
}
