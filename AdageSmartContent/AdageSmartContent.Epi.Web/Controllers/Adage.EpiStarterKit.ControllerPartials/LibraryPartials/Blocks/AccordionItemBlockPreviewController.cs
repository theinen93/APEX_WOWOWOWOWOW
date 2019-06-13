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
    /// Custom preview controller for accordion item block.  Refreshes accordion content when adjusted in OPE.
    /// </summary>
    [TemplateDescriptor(
        Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController,
        Tags = new[] { RenderingTags.Preview },
        ModelType = typeof(AccordionItemBlock),
        AvailableWithoutTag = false)]
    public partial class AccordionContainerItemPreviewController : PreviewBlockController<AccordionItemBlock>
    {
        #region Constructors
        public AccordionContainerItemPreviewController(IViewModelFactory viewModelFactory) : base(viewModelFactory)
        {
        }
        #endregion

        public override ActionResult Index(AccordionItemBlock currentBlock)
        {
            var editingHints = ViewData.GetEditHints<IBlockViewModel<AccordionItemBlock>, AccordionItemBlock>();
            editingHints.AddFullRefreshFor(p => p.AccordionContent);

            return base.Index(currentBlock);
        }
    }
}