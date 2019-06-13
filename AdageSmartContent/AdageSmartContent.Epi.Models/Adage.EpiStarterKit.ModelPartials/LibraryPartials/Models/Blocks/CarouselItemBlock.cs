using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adage.EpiStarterKit.ModelPartials.Static;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(CarouselItemBlock), GroupName = ContentGroupNames.CarouselBlock,
        DisplayName = "Carousel Item", GUID = "a4d6cbcb-98e4-4e93-b1f8-8a983e40e37c", Description = "Displays image or video slides in clickable carousel.  Should only be used within Carousel Cotainer Blocks.")]
    public partial class CarouselItemBlock : AdageBaseBlock
    {
        [CultureSpecific]
        [Display(
            Name = "Caption",
            Description = "Displayed caption for any gallery item.",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual XhtmlString ImageCaption { get; set; }

        [Display(
            Name = "Image",
            Description = "Displays an image as the gallery item. Will override other fields if multiple are populated.",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ImageFile { get; set; }

        [Display(
            Name = "YouTube ID",
            Description = "Displays a YouTube video as the gallery item.",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual string YouTubeId { get; set; }

        [Display(
            Name = "Vimeo ID",
            Description = "Displays a Vimeo video as the gallery item.",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual string VimeoId { get; set; }

        [Display(
            Name = "Video Reference",
            Description = "Displays an embedded video as the gallery item.",
            GroupName = SystemTabNames.Content,
            Order = 500)]
        [UIHint(UIHint.Video)]
        public virtual ContentReference VideoReference { get; set; }

    }
}
