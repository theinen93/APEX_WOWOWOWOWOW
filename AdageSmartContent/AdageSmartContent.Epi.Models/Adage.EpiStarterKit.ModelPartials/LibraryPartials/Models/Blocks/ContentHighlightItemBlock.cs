using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.Static;
using Adage.EpiStarterKit.ModelPartials.Models.Blocks;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(ContentHighlightItemBlock),
        GroupName = ContentGroupNames.ContentHighlightBlock,
        DisplayName = "Content Highlight Item Block",
        GUID = "aa25da75-f97f-4c3d-842b-e0c48d15d955",
        Description = "Individual items placed inside of a Content Highlight Container block. Should only be used within Content Highlight Container block.")]
    [SiteImagesUrl("Block-Highlight-Item.png")]
    public partial class ContentHighlightItemBlock : AdageBaseBlock
    {
        [Display(Name = "Image Block", Description = "Image Displayed in Item block", Order = 100, GroupName = SystemTabNames.Content)]
        public virtual ImageBlock ImageBlock { get; set; }

        [Display(Name = "Text Area", Description = "Text area displayed in item block", Order = 200, GroupName = SystemTabNames.Content)]
        public virtual XhtmlString TextArea { get; set; }

        [Display(Name = "Call to Action", Description = "Link block diplayed in item block", Order = 300, GroupName = SystemTabNames.Content)]
        public virtual LinkBlock LinkBlock { get; set; }
    }
}