using Adage.EpiStarterKit.ModelPartials.Static;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Models.Pages
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(ContainerPage),
        DisplayName = "Container Page", GroupName = ContentGroupNames.BasePages,
        GUID = "D178950C-D20E-4A46-90BD-5338B2424745", Description = "A page for holding other pages.")]
    [SiteImagesUrl("Page-Container.png")]
    public partial class ContainerPage : PageData, IContainerPage
    {
    }
}
