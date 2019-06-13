using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.LibraryPartials.Static;
using Adage.EpiStarterKit.ModelPartials.Static;
using Adage.EpiStarterKit.ModelPartials.Models.Pages;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [StarterKitContentType(CurrentType: typeof(StaffInfoItemBlock), GroupName = ContentGroupNames.StaffInfoBlock,
        DisplayName = "Staff Info Item Block", GUID = "d56941dc-633b-413b-a1d9-67bc23596cbc", Description = "Displays information on a staff memeber")]
    [SiteImagesUrl("Block-Staff-Info.png")]
    public partial class StaffInfoItemBlock : AdageBaseBlock
    {
        [Display(
            Name = "Image",
            Description = "An image of the staff member",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual ImageBlock StaffImage { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "The name of the staff member",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual string StaffName { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Role",
            Description = "The staff member's role/department",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual string StaffRole { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Information",
            Description = "Additional information about the staff member",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual XhtmlString StaffInfo { get; set; }
    }
}