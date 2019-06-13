using Adage.EpiStarterKit.ControllerPartials.Base;
using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels;
using EPiServer;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Framework.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adage.EpiStarterKit.ControllerPartials.Blocks
{
    [TemplateDescriptor(
        Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController,
        Tags = new[] { RenderingTags.Preview },
        ModelType = typeof(AdageBaseBlock),
        AvailableWithoutTag = false)]
    public partial class PreviewBlockController<T> : AdageBaseBlockController<T> where T : AdageBaseBlock
    {
        #region Properties
        protected virtual string DefaultBlockName { get; } = "DefaultBlock";
        #endregion

        #region Constructors
        public PreviewBlockController(IViewModelFactory viewModelFactory) : base(viewModelFactory)
        {
        }
        #endregion

        #region Overrides
        protected override string RootFileName { get; } = "{0}/{1}PreviewView.cshtml";

        protected override string GetViewLocation(T currentBlock)
        {
            var blockName = currentBlock.GetOriginalType().Name;

            var clientBlockSpecificPreviewViewLocation = string.Format(RootFileName, ClientViewsRoot, blockName);
            var kitBlockSpecificPreviewViewLocation = string.Format(RootFileName, AdageViewsRoot, blockName);

            var clientBlockDefaultPreviewViewLocation = string.Format(RootFileName, ClientViewsRoot, DefaultBlockName); ;
            var kitBlockDefaultPreviewViewLocation = string.Format(RootFileName, AdageViewsRoot, DefaultBlockName); ;



            if (System.IO.File.Exists(Server.MapPath(clientBlockSpecificPreviewViewLocation)))
                return clientBlockSpecificPreviewViewLocation;
            else if (System.IO.File.Exists(Server.MapPath(kitBlockSpecificPreviewViewLocation)))
                return kitBlockSpecificPreviewViewLocation;
            else if (System.IO.File.Exists(Server.MapPath(clientBlockDefaultPreviewViewLocation)))
                return clientBlockDefaultPreviewViewLocation;
            else
                return kitBlockDefaultPreviewViewLocation;
        }
        #endregion
    }
}