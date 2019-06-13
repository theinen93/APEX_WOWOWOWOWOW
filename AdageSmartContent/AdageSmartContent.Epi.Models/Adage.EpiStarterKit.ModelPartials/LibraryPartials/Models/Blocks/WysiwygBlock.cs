using Adage.EpiStarterKit.ModelPartials.Static;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(WysiwygBlock),
        GroupName = ContentGroupNames.BaseBlocks,
        DisplayName = "WYSIWYG Block",
        GUID = "40cc91ed-85d3-4013-8a65-579cd3e5f5a4",
        Description = "A WYSIWYG block that can be used for multiple purposes")]
    [SiteImagesUrl("Block-WYSIWYG.png")]
    public partial class WysiwygBlock : AdageBaseBlock
    {
        [CultureSpecific]
        [Display(
            Name = "WYSIWYG Content",
            Description = "The Content that will be displayed in the block",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual XhtmlString WysiwygContent { get; set; }
    }
}
