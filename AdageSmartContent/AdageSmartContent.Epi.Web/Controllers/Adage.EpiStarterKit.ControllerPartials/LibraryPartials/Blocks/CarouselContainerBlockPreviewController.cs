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
    /// Custom preview controller for carousel container block.  Refreshes galllery when adjusted in OPE.
    /// </summary>
    [TemplateDescriptor(
        Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController,
        Tags = new[] { RenderingTags.Preview },
        ModelType = typeof(CarouselContainerBlock),
        AvailableWithoutTag = false)]
    public partial class CarouselContainerBlockPreviewController : PreviewBlockController<CarouselContainerBlock>
    {
        #region Constructors
        public CarouselContainerBlockPreviewController(IViewModelFactory viewModelFactory) : base(viewModelFactory)
        {
        }
        #endregion

        public override ActionResult Index(CarouselContainerBlock currentBlock)
        {
            var editingHints = ViewData.GetEditHints<IBlockViewModel<CarouselContainerBlock>, CarouselContainerBlock>();
            editingHints.AddFullRefreshFor(p => p.ImageCarouselContentArea);

            return base.Index(currentBlock);
        }
    }
}