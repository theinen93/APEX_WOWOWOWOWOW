using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.LibraryPartials.Static;
using Adage.EpiStarterKit.ModelPartials.Static;
using Adage.EpiStarterKit.ModelPartials.Models.Blocks;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [StarterKitContentType(CurrentType: typeof(ImageTextContainerBlock), GroupName = ContentGroupNames.ImageTextBlock,
        DisplayName = "Image & Text Container Block", GUID = "1268c031-0c91-4fa9-bca4-1d97cbd07768", Description = "Container to hold image & text item blocks. Place Image & Text Item Blocks in here")]
    [SiteImagesUrl("Block-Image-Text-List-Container.png")]
    public partial class ImageTextContainerBlock : AdageBaseBlock
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title of Image & Text Container",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Title { get; set; }

        [Display(
            Name = "Image & Text Items",
            Description = "Image & Text Container Block",
            GroupName = SystemTabNames.Content, Order = 200)]
        [AllowedTypes(new[] { typeof(ImageTextItemBlock) })]
        public virtual ContentArea ImageTextContentArea { get; set; }

        [Display(
            Name = "Call To Action",
            Description = "Properties to control the call to action on this block",
            GroupName = SystemTabNames.Content, Order = 300)]
        public virtual LinkBlock CallToAction { get; set; }
    }
}