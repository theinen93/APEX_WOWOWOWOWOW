using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using Adage.EpiStarterKit.ModelPartials.Static;

namespace Adage.EpiStarterKit.ModelPartials.Models.Pages
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(HomePage),
        DisplayName = "Home Page", GroupName = ContentGroupNames.BasePages,
        GUID = "d3dfeef6-70b8-4f2e-9bf8-aa1cc9920a41", Description = "The starting page of the website")]
    [SiteImagesUrl("Page-Home.png")]
    public partial class HomePage : AdageBasePage
    {
        #region Content
        [CultureSpecific]
        [Display(Name = "Main Content Area", Description = "Content Area that allows you to add blocks to page", Order = 100, GroupName = SystemTabNames.Content)]
        public virtual ContentArea MainContentArea { get; set; }
        #endregion

        #region Settings
        [CultureSpecific]
        [Display(Name = "Settings Page", Description = "The settings page for the site", Order = 100, GroupName = TabNames.SETTINGS)]
        [AllowedTypes(typeof(SiteSettingsPage))]
        public virtual ContentReference SiteSettingsPage { get; set; }
        #endregion
    }
}