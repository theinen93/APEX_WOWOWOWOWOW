using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.Static;
using Adage.EpiStarterKit.ModelPartials.Models.Media;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(LogosContainerBlock), GroupName = ContentGroupNames.BaseBlocks,
        DisplayName = "Logos Container Block", GUID = "49282d44-6b45-4430-9e2c-b5fb43a92d31", Description = "Displays uploaded sponsor logo images in a row.")]
    public partial class LogosContainerBlock : AdageBaseBlock
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title of the Logos Block",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Title { get; set; }

        [AllowedTypes(new[] { typeof(ImageFile), typeof(ImageBlock) })]
        [Display(
            Name = "Logos",
            Description = "Accepts straight image files to display as logos",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual ContentArea LogosContentArea { get; set; }
    }
}