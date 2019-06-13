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
    /// Custom preview controller for accordion container block.  Refreshes accordion items when adjusted in OPE.
    /// </summary>
    [TemplateDescriptor(
        Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController,
        Tags = new[] { RenderingTags.Preview },
        ModelType = typeof(AccordionContainerBlock),
        AvailableWithoutTag = false)]
    public partial class AccordionContainerBlockPreviewController : PreviewBlockController<AccordionContainerBlock>
    {
        #region Constructors
        public AccordionContainerBlockPreviewController(IViewModelFactory viewModelFactory) : base(viewModelFactory)
        {
        }
        #endregion

        public override ActionResult Index(AccordionContainerBlock currentBlock)
        {
            var editingHints = ViewData.GetEditHints<IBlockViewModel<AccordionContainerBlock>, AccordionContainerBlock>();
            editingHints.AddFullRefreshFor(p => p.AccordionContentArea);

            return base.Index(currentBlock);
        }
    }
}