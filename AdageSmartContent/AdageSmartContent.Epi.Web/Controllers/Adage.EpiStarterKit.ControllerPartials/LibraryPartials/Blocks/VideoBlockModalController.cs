using Adage.EpiStarterKit.ControllerPartials.Base;
using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.RenderingPartials;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels;
using EPiServer.Framework.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adage.EpiStarterKit.ControllerPartials.Blocks
{
    [TemplateDescriptor(
        Inherited = true,
        Tags = new[] { Tags.FIFTY_FIFTY, Tags.COLUMN_AUTO_CONTAINER },
        ModelType = typeof(VideoBlock),
        AvailableWithoutTag = false)]
    public partial class VideoBlockModalController : AdageBaseBlockController<VideoBlock>
    {
        #region Constructors
        public VideoBlockModalController(IViewModelFactory viewModelFactory) : base(viewModelFactory)
        {
        }
        #endregion

        #region Overrides
        protected override string GetBlockName(VideoBlock currentBlock)
        {
            return "VideoBlockModal";
        }
        #endregion
    }
}