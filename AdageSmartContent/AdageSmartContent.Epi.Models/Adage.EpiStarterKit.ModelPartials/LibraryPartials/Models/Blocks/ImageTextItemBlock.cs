using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.Static;
using Adage.EpiStarterKit.ModelPartials.LibraryPartials.Static;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [StarterKitContentType(CurrentType: typeof(ImageTextItemBlock), GroupName = ContentGroupNames.ImageTextBlock,
        DisplayName = "Image & Text Item Block", GUID = "10e38a5e-2d8b-45c7-ad38-fe0e9c3c5481", Description = "Displays an image and text. Should only be used within Image & Text Container Blocks")]
    [SiteImagesUrl("Block-Image-Text-List.png")]
    public partial class ImageTextItemBlock : AdageBaseBlock
    {
        [Display(
            Name = "Image",
            Description = "The image to accompany the text",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual ImageBlock Image { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Pre-Title",
            Description = "Text displayed above Title",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual string PreTitle { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title of the block",
            Order = 300,
            GroupName = SystemTabNames.Content)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Content",
            Description = "The text to accompany the image",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual XhtmlString WysiwygContent { get; set; }
    }
}