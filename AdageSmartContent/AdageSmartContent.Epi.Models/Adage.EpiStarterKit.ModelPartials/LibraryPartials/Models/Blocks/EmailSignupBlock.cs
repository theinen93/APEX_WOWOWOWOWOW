using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.LibraryPartials.Static;
using Adage.EpiStarterKit.ModelPartials.Static;
using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using EPiServer.Shell.ObjectEditing;
using Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.DropdownList;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [StarterKitContentType(CurrentType: typeof(EmailSignupBlock), GroupName = ContentGroupNames.BaseBlocks,
        DisplayName = "Email Signup Block", GUID = "fcd857f6-cb13-4150-82ad-74409e7654c4", Description = "Used to collect email addresses for an external list server or marketing automation platform. If applicable, the block can send along the inputted email address to the external website.")]
    [SiteImagesUrl("Block-Email-Sign-Up.png")]
    public partial class EmailSignupBlock : AdageBaseBlock
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Large heading for the Email Signup Block.",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Background Color",
            Description = "Background color for the block",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        [EditorDescriptor(EditorDescriptorType = typeof(DictionaryEditorDescriptor<SelectionDictionary.BackgroundColors>))]
        public virtual string BackgroundColors { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Message",
            Description = "The main content to display",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual XhtmlString WysiwygContent { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Text Box Label",
            Description = "Description of what the user should put in the text box",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual string TextBoxTitle { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Placeholder Text",
            Description = "An example of what the user should put in the text box",
            GroupName = SystemTabNames.Content,
            Order = 500)]
        public virtual string PlaceholderText { get; set; }

        [Display(
            Name = "Call to Action",
            Description = "Inserting the token {{EMAIL}} into the website url will dynamically replace this token with the value of the textbox before redirecting the user.",
            GroupName = SystemTabNames.Content,
            Order = 600)]
        public virtual LinkBlock CallToAction { get; set; }

    }
}