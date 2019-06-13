using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Adage.EpiStarterKit.ModelPartials.Static;
using EPiServer.Shell.ObjectEditing;
using Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.Factories;
using EPiServer;
using EPiServer.ServiceLocation;
using Adage.EpiStarterKit.ModelPartials.Models.Media;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(ImageBlock), GroupName = ContentGroupNames.BaseBlocks,
        DisplayName = "Image Block", GUID = "7165efe4-2b16-4d08-90af-26b1eb1ce056", Description = "Container for an image, along with a caption.")]
    [SiteImagesUrl("Block-Image.png")]
    public partial class ImageBlock : BaseLinkBlock
    {
        [CultureSpecific]
        [Display(
            Name = "Image",
            Description = "Block to be used to display images",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }
    }
}