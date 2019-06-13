using Adage.EpiStarterKit.ViewModelPartials.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer.Web.Mvc;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using Adage.EpiStarterKit.ModelPartials.Models.Blocks;

namespace Adage.EpiStarterKit.ControllerPartials.Blocks
{
    /// <summary>
    /// Custom preview controller for staff info container block.  Refreshes staff items when adjusted in OPE.
    /// </summary>
    [TemplateDescriptor(
        Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController,
        Tags = new[] { RenderingTags.Preview },
        ModelType = typeof(StaffInfoContainerBlock),
        AvailableWithoutTag = false)]
    public partial class StaffInfoContainerBlockPreviewController : PreviewBlockController<StaffInfoContainerBlock>
    {
        #region Constructors
        public StaffInfoContainerBlockPreviewController(IViewModelFactory viewModelFactory) : base(viewModelFactory)
        {
        }
        #endregion

        public override ActionResult Index(StaffInfoContainerBlock currentBlock)
        {
            var editingHints = ViewData.GetEditHints<IBlockViewModel<StaffInfoContainerBlock>, StaffInfoContainerBlock>();
            editingHints.AddFullRefreshFor(p => p.StaffInfoContentArea);

            return base.Index(currentBlock);
        }
    }
}