using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.LibraryPartials.Static;
using Adage.EpiStarterKit.ModelPartials.Static;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [StarterKitContentType(CurrentType: typeof(StaffInfoContainerBlock), GroupName = ContentGroupNames.StaffInfoBlock,
        DisplayName = "Staff Info Container Block", GUID = "49b1a48f-4177-4c61-9597-6f70d69fcb6c", Description = "Container to hold Staff Info Item Block.")]
    [SiteImagesUrl("Block-Staff-Info-Container.png")]
    public partial class StaffInfoContainerBlock : AdageBaseBlock
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title of the Staff Info Container",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Title { get; set; }

        [Display(
            Name = "Staff Info Items",
            Description = "Staff Info Container Block",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        [AllowedTypes(new[] { typeof(StaffInfoItemBlock) })]
        public virtual ContentArea StaffInfoContentArea { get; set; }

        [Display(
            Name = "Hide Staff Images",
            Description = "Checking this box will hide all staff images from Staff item blocks in this container",
            Order = 250,
            GroupName = SystemTabNames.Content)]
        public virtual bool HideStaffImages { get; set; }

        [Display(
            Name = "Call To Action",
            Description = "Properties to control the call to action on this block",
            GroupName = SystemTabNames.Content, Order = 300)]
        public virtual LinkBlock CallToAction { get; set; }


    }
}