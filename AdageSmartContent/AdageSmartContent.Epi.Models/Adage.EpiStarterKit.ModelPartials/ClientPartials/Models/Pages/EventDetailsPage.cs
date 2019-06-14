using System;
using System.ComponentModel.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace Adage.EpiStarterKit.ModelPartials.Models.Pages
{
    [ContentType(DisplayName = "Event Details Page", GUID = "db683d22-61a4-406a-9f94-e24db5341634", Description = "")]
    public class EventDetailsPage : AdageBasePage
    {
        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(Name = "Header Image", Description = "EDP image that will appear as the page header.", Order = 100, GroupName = SystemTabNames.Content)]
        public virtual Url HeaderImage { get; set; }

        [CultureSpecific]
        [Display(Name = "Title", Description = "Title of the event", Order = 200, GroupName = SystemTabNames.Content)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(Name = "Description", Description = "WYSIWYG area to describe the event. Use bullets, underlining and whatever else you need.", Order = 300, GroupName = SystemTabNames.Content)]
        public virtual XhtmlString Description { get; set; }

        [CultureSpecific]
        [Display(Name = "Date And Time", Description = "Date and time of the event. Use format: Thursday, October 11, 2018 3:00PM - 6:00PM", Order = 400, GroupName = SystemTabNames.Content)]
        public virtual XhtmlString DateAndTime { get; set; }

        [CultureSpecific]
        [Display(Name = "Location Name And Address", Description = "Name and Address", Order = 500, GroupName = SystemTabNames.Content)]
        public virtual XhtmlString LocationNameAndAddress { get; set; }

        [CultureSpecific]
        [Display(Name = "Price", Description = "Price for Member and Price for non-member. Use format: Free Member, $10 Non-Member", Order = 600, GroupName = SystemTabNames.Content)]
        public virtual XhtmlString Price { get; set; }

        [CultureSpecific]
        [Display(Name = "CTA Button Text", Description = "Text for call-to-action (ex. RSVP Now)", Order = 700, GroupName = SystemTabNames.Content)]
        public virtual string CTAButtonText { get; set; }

        [CultureSpecific]
        [Display(Name = "CTA Button Url", Description = "Text for call-to-action (ex. RSVP Now)", Order = 700, GroupName = SystemTabNames.Content)]
        public virtual Url CTAButtonUrl { get; set; }
    }
}