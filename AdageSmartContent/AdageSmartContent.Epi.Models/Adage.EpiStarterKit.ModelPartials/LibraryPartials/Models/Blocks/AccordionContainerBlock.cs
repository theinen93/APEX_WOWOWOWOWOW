using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.Static;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(AccordionContainerBlock),
        GroupName = ContentGroupNames.AccordionBlock,
        DisplayName = "Accordion Container Block",
        GUID = "7ec89237-644b-420a-8a4a-8985f2abb783",
        Description = "Top level container block for Accordion Blocks.  Place Accordion Item Blocks in here.")]
    [SiteImagesUrl("Block-Accordion-Container.png")]
    public partial class AccordionContainerBlock : AdageBaseBlock
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title for the Accordion Block",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Title { get; set; }

        [Display(
            Name = "Accordion Items",
            Description = "Accordion Container Block",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        [AllowedTypes(typeof(AccordionItemBlock))]
        public virtual ContentArea AccordionContentArea { get; set; }
    }
}