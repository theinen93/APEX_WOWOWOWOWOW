using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using EPiServer.Editor;
using EPiServer.Shell;

namespace Adage.EpiStarterKit.ModelPartials.UI
{
    /// <summary>
    /// Describes how the UI should appear for <see cref="ContainerPage"/> content.
    /// </summary>
    /// <remarks>
    /// From Alloy Demo Site
    /// </remarks>
    [UIDescriptorRegistration]
    public partial class ContainerPageUIDescriptor : UIDescriptor<ContainerPage>
    {
        public ContainerPageUIDescriptor()
            : base(ContentTypeCssClassNames.Container)
        {
            DefaultView = CmsViewNames.AllPropertiesView;
        }
    }
}