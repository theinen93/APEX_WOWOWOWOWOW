using Adage.EpiStarterKit.ControllerPartials.Base;
using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;

namespace Adage.EpiStarterKit.ControllerPartials.Blocks
{
    [TemplateDescriptor(
        Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController,
        Tags = new[] { RenderingTags.Preview },
        ModelType = typeof(BaseLinkBlock),
        AvailableWithoutTag = false)]
    public partial class AdageLinkBlockPreviewController : PreviewBlockController<BaseLinkBlock>
    {
        #region Constructors
        public AdageLinkBlockPreviewController(IViewModelFactory viewModelFactory) : base(viewModelFactory)
        {
        }
        #endregion

        /// <summary>
        /// Default block handler.
        /// </summary>
        /// <param name="currentBlock">Any block of type BaseLinkBlock.</param>
        /// <returns></returns>
        public override ActionResult Index(BaseLinkBlock currentBlock)
        {
            var modelType = currentBlock.GetOriginalType();
            var viewType = typeof(IBaseLinkBlockViewModel<>).MakeGenericType(modelType);
            var viewModel = ViewModelFactory.GetViewModel(viewType, modelType, currentBlock) as IBaseLinkBlockViewModel<BaseLinkBlock>;

            viewModel.CssClass = ControllerContext.ParentActionViewContext?.ViewData["cssClass"] as string ?? string.Empty;

            return View(GetViewLocation(currentBlock), viewModel);
        }
    }
}