using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace Adage.EpiStarterKit.RenderingPartials
{
    public partial class AdageTemplateCoordinator : IViewTemplateModelRegistrator
    {
        public static void OnTemplateResolved(object sender, TemplateResolverEventArgs args)
        {
            //Disable controller for page types that shouldn't have any renderer as pages
            if (args.ItemToRender is IContainerPage)
            {
                args.SelectedTemplate = null;
            }
        }

        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {

        }
    }
}