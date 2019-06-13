using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using Adage.EpiStarterKit.ModelPartials.Static;
using EPiServer.Shell.ObjectEditing;
using Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.Factories;
using Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.DropdownList;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(FiftyFiftyBlock), GroupName = ContentGroupNames.BaseBlocks,
        DisplayName = "Fifty-fifty Block", GUID = "8c4ce615-841e-4dab-82e5-04941684e87b", Description = "Block that displays two types of content (video, image, or text)")]
    [SiteImagesUrl("Block-Fifty-Fifty-Container.png")]
    public partial class FiftyFiftyBlock : AdageBaseBlock
    {
        [CultureSpecific]
        [Display(
            Name = "Order of Blocks at Mobile Breakpoint",
            Description = "Order in which the left and right sides will stack at smaller browser screen widths.",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        [SelectOne(SelectionFactoryType = typeof(FiftyFiftySwapSelectionFactory))]
        public virtual string Order { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Left Tile Theme",
            Description = "Theme for the left side of the block",
            GroupName = SystemTabNames.Content,
            Order = 250)]
        [EditorDescriptor(EditorDescriptorType = typeof(DictionaryEditorDescriptor<SelectionDictionary.FiftyFiftyBackgroundColors>))]
        public virtual string LeftBackgroundColors { get; set; }

        [Display(
            Name = "Left Tile Image",
            Description = "Image displayed on left tile",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual ImageBlock LeftImageFile { get; set; }

        [Display(
            Name = "Left Tile Video",
            Description = "Video displayed in left side tile",
            Order = 400,
            GroupName = SystemTabNames.Content)]
        public virtual VideoBlock LeftVideoBlock { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Left Tile WYSIWYG",
            Description = "Leave blank to use a different type of content here.",
            GroupName = SystemTabNames.Content,
            Order = 500)]
        public virtual XhtmlString LeftDescription { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Right Tile Theme",
            Description = "Theme for the right side of the block",
            GroupName = SystemTabNames.Content,
            Order = 550)]
        [EditorDescriptor(EditorDescriptorType = typeof(DictionaryEditorDescriptor<SelectionDictionary.FiftyFiftyBackgroundColors>))]
        public virtual string RightBackgroundColors { get; set; }

        [Display(
            Name = "Right Tile Image",
            Description = "Image displayed on right tile",
            GroupName = SystemTabNames.Content,
            Order = 600)]
        public virtual ImageBlock RightImageFile { get; set; }

        [Display(
            Name = "Right Tile Video",
            Description = "Video displayed in right side tile",
            Order = 700,
            GroupName = SystemTabNames.Content)]
        public virtual VideoBlock RightVideoBlock { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Right Tile WYSIWYG",
            Description = "Leave blank to use a different type of content here.",
            GroupName = SystemTabNames.Content,
            Order = 1200)]
        public virtual XhtmlString RightDescription { get; set; }
    }
}