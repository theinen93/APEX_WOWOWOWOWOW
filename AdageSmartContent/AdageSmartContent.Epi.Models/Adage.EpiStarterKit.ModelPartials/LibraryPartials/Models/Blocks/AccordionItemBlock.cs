using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.Static;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(AccordionItemBlock),
        GroupName = ContentGroupNames.AccordionBlock,
        DisplayName = "Accordion Item Block",
        GUID = "fc3b8dc5-f70f-4b61-90a2-78067d0d5169",
        Description = "Individual items placed inside of a Accordion Block. Should only be used within Accordion Container Blocks.")]
    [SiteImagesUrl("Block-Accordion-Item.png")]
    public partial class AccordionItemBlock : AdageBaseBlock
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title of the Accordion Item",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Accordion Content",
            Description = "The content of the Accordion Item",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual XhtmlString AccordionContent { get; set; }
    }
}