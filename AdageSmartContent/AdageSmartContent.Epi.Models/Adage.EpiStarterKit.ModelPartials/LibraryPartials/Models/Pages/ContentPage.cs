using Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.Factories;
using Adage.EpiStarterKit.ModelPartials.Static;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Models.Pages
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(ContentPage),
        DisplayName = "Content Page", GroupName = ContentGroupNames.BasePages,
        GUID = "1baade0a-45f7-4da3-9acb-83ebb490927b", Description = "A page with a title and a content area for blocks")]
    [SiteImagesUrl("Page-General-Content.png")]
    public partial class ContentPage : AdageBasePage
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Page Heading.",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Title { get; set; }

        [Display(
            Name = "Content Area",
            Description = "Area to host blocks on the page.",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual ContentArea ContentArea { get; set; }
    }
}
