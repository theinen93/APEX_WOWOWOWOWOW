using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adage.EpiStarterKit.ModelPartials.Static;
using Adage.EpiStarterKit.ModelPartials.LibraryPartials.Static;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [StarterKitContentType(CurrentType: typeof(CarouselContainerBlock), GroupName = ContentGroupNames.CarouselBlock,
    DisplayName = "Carousel Block", GUID = "8a7fe88b-b568-4cf9-958a-56f299fff842", Description = "Container to hold image or video slides in carousel.")]
    [SiteImagesUrl("Block-Gallery-Container.png")]
    public partial class CarouselContainerBlock : AdageBaseBlock
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title of the Carousel Container",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Title { get; set; }

        [AllowedTypes(new[] { typeof(CarouselItemBlock) })]
        [Display(
            Name = "Carousel Items",
            Description = "Carousel Container Block",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual ContentArea ImageCarouselContentArea { get; set; }
    }
}
