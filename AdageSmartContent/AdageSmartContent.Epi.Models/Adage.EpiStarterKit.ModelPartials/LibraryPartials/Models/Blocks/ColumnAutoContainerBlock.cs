using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.Static;
using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ModelPartials.Static.Attributes;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(ColumnAutoContainerBlock),
        GroupName = ContentGroupNames.ColumnAutoContainerBlock,
        DisplayName = "Content Highlight Container Block",
        GUID = "7e7a4ada-1175-4d42-b15d-b67d9bc05222",
        Description = "Container block for Automatic Width Columns")]
    [SiteImagesUrl("Block-Highlight-Container.png")]
    public partial class ColumnAutoContainerBlock : AdageBaseBlock
    {
        [CultureSpecific]
        [Display(Name = "Title", Description = "Heading for this container", Order = 100, GroupName = SystemTabNames.Content)]
        public virtual string Title { get; set; }

        [Display(Name = "Content Item Area", Description = "Content Area that accepts a set number of blocks as columns", Order = 200, GroupName = SystemTabNames.Content)]
        [AllowedTypes(typeof(ContentHighlightItemBlock), typeof(ImageBlock), typeof(VideoBlock))]
        [ContentCountLimit(0, 5)]
        public virtual ContentArea ContentItemArea { get; set; }

        [Display(Name = "Call To Action", Order = 300,
            Description = "Properties to control the call to action on this block",
            GroupName = SystemTabNames.Content)]
        public virtual LinkBlock CallToAction { get; set; }
    }
}