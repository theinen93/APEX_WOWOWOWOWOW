using Adage.EpiStarterKit.ModelPartials.BusObj;
using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks;
using Adage.EpiStarterKit.ViewModelPartials.BusObj;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Adage.EpiStarterKit.ViewModelPartials.LibraryPartials.Static.ViewModelEnums;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks
{
    public partial class FiftyFiftyBlockViewModel : BlockViewModel<FiftyFiftyBlock>, IFiftyFiftyBlockViewModel
    {
        #region Constructors
        public FiftyFiftyBlockViewModel(FiftyFiftyBlock currentBlock) : base(currentBlock)
        {
        }
        #endregion

        public FiftyFiftyContentType LeftContentType
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(CurrentBlock.LeftVideoBlock.YouTubeId))
                {
                    return FiftyFiftyContentType.Video;
                }
                else if (!String.IsNullOrWhiteSpace(CurrentBlock.LeftVideoBlock.VimeoId))
                {
                    return FiftyFiftyContentType.Video;
                }
                else if (!ContentReference.IsNullOrEmpty(CurrentBlock.LeftVideoBlock.VideoReference))
                {
                    return FiftyFiftyContentType.Video;
                }
                else if (!ContentReference.IsNullOrEmpty(CurrentBlock.LeftImageFile.Image))
                {
                    return FiftyFiftyContentType.Image;
                }
                else
                    return FiftyFiftyContentType.Default;
            }
        }

        public FiftyFiftyContentType RightContentType
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(CurrentBlock.RightVideoBlock.YouTubeId))
                    return FiftyFiftyContentType.Video;
                else if (!String.IsNullOrWhiteSpace(CurrentBlock.RightVideoBlock.VimeoId))
                    return FiftyFiftyContentType.Video;
                else if (!ContentReference.IsNullOrEmpty(CurrentBlock.RightVideoBlock.VideoReference))
                    return FiftyFiftyContentType.Video;
                else if (!ContentReference.IsNullOrEmpty(CurrentBlock.RightImageFile.Image))
                    return FiftyFiftyContentType.Image;
                else
                    return FiftyFiftyContentType.Default;
            }
        }

        public bool ReversedOnMobile
        {
            get
            {
                return CurrentBlock.Order == "true" ? true : false;
            }
        }
    }
}
