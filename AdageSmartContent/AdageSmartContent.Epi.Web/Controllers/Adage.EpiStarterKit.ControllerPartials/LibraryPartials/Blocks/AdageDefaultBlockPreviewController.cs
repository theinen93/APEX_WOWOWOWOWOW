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
    [TemplateDescriptor(
        Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController,
        Tags = new[] { RenderingTags.Preview },
        ModelType = typeof(AdageBaseBlock),
        AvailableWithoutTag = false)]
    public partial class AdageDefaultPreviewBlockController : PreviewBlockController<AdageBaseBlock>
    {
        #region Constructors
        public AdageDefaultPreviewBlockController(IViewModelFactory viewModelFactory) : base(viewModelFactory)
        {
        }
        #endregion
    }
}