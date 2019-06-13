using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ModelPartials.Static;
using EPiServer.Shell.ObjectEditing;
using System.Collections.Generic;
using Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.Factories;
using Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.DropdownList;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(FullWidthCTABlock), GroupName = ContentGroupNames.BaseBlocks,
    DisplayName = "Full Width CTA Block", GUID = "3dbf2187-fb0d-444b-9338-a02eeaf30f26", Description = "Displays a full width message and a call to action")]
    [SiteImagesUrl("Block-Full-Width-CTA.png")]
    public partial class FullWidthCTABlock : AdageBaseBlock
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title of the Full Width Content Block",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Message",
            Description = "The main content to display above the call to action",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual XhtmlString WysiwygContent { get; set; }

        [Display(
            Name = "Call to Action",
            Description = "Properties to control the call to action on this block",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual LinkBlock CallToAction { get; set; }

        [Display(
            Name = "Theme",
            Description = "List of themes that can be applied to the styling of this block.",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        [EditorDescriptor(EditorDescriptorType = typeof(DictionaryEditorDescriptor<SelectionDictionary.BackgroundColors>))]
        public virtual string BackgroundColors { get; set; }
    }
}