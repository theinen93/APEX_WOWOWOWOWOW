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
    /// Custom preview controller for email block.  Fixes on-page editing for placeholder text on block.
    /// </summary>
    [TemplateDescriptor(
        Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController,
        Tags = new[] { RenderingTags.Preview },
        ModelType = typeof(EmailSignupBlock),
        AvailableWithoutTag = false)]
    public partial class EmailSignupBlockPreviewController : PreviewBlockController<EmailSignupBlock>
    {
        #region Constructors
        public EmailSignupBlockPreviewController(IViewModelFactory viewModelFactory) : base(viewModelFactory)
        {
        }
        #endregion

        public override ActionResult Index(EmailSignupBlock currentBlock)
        {
            var editingHints = ViewData.GetEditHints<IBlockViewModel<EmailSignupBlock>, EmailSignupBlock>();
            editingHints.AddFullRefreshFor(p => p.PlaceholderText);

            return base.Index(currentBlock);
        }
    }
}