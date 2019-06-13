using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using EPiServer.Editor;
using EPiServer.Shell;

namespace Adage.EpiStarterKit.ModelPartials.UI
{
    /// <summary>
    /// Describes how the UI should appear for <see cref="SiteSettingsPage"/> content.
    /// </summary>
    /// <remarks>
    /// Inspirted by Alloy Demo Site
    /// </remarks>
    [UIDescriptorRegistration]
    public partial class SiteSettingsPageUIDescriptor : UIDescriptor<SiteSettingsPage>
    {
        public const string EPI_GEAR_ICON_CLASS = "epi-iconSettings";

        public SiteSettingsPageUIDescriptor()
            : base(EPI_GEAR_ICON_CLASS)
        {
            DefaultView = CmsViewNames.AllPropertiesView;
        }
    }
}
