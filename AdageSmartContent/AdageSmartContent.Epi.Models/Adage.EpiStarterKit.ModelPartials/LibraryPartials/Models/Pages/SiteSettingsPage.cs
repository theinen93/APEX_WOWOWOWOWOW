using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ModelPartials.Static;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.SpecializedProperties;
using EPiServer.DataAbstraction;

namespace Adage.EpiStarterKit.ModelPartials.Models.Pages
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(SiteSettingsPage),
        DisplayName = "Site Settings Page", GroupName = ContentGroupNames.BasePages,
        GUID = "196f7654-059f-4ba2-a0cb-7024ef780875", Description = "Core configurations for the entire website.")]
    [SiteImagesUrl("Page-Site-Settings.png")]
    public partial class SiteSettingsPage : AdageBasePage
    {
        #region Content Tab
        [Display(Name = "Links in Utility Navigation", Description = "Links to be used in the Utility Navigation", Order = 100, GroupName = SystemTabNames.Content)]
        public virtual LinkItemCollection UtilityNavLinks { get; set; }

        [Display(Name = "Site Logo", Description = "The logo which will appear in the header of the site", Order = 200, GroupName = SystemTabNames.Content)]
        [UIHint(UIHint.Image)]
        public virtual ImageBlock Logo { get; set; }

        [Display(Name = "Search Box Placeholder Text", Description = "Placeholder text for the search box", Order = 300, GroupName = SystemTabNames.Content)]
        public virtual string SearchPlaceholderText { get; set; }

        [Display(Name = "Search Box Button Text", Description = "Button text for the search box submit button", Order = 400, GroupName = SystemTabNames.Content)]
        public virtual string SearchButtonText { get; set; }
        #endregion

        #region Scripts
        [Display(Name = "Global Head Scripts", Description = "The scripts will be injected to page <head> node", Order = 100, GroupName = TabNames.SCRIPTS)]
        [UIHint(UIHint.Textarea)]
        public virtual string GlobalHeadScripts { get; set; }

        [Display(Name = "Global Body Scripts", Description = "The scripts will be injected to page <body> node", Order = 200, GroupName = TabNames.SCRIPTS)]
        [UIHint(UIHint.Textarea)]
        public virtual string GlobalBodyScripts { get; set; }
        #endregion

        #region Settings
        [Display(Name = "Facebook App ID", Description = "Facebook app id to be used in meta tag", Order = 100, GroupName = TabNames.SETTINGS)]
        public virtual string FacebookAppId { get; set; }
        #endregion

        #region Footer
        [CultureSpecific]
        [Display(Name = "Left WYSIWYG", Description = "WYSIWYG displayed in the left column of the footer", Order = 10, GroupName = TabNames.FOOTER)]
        public virtual XhtmlString LeftWYSIWYG { get; set; }

        [CultureSpecific]
        [Display(Name = "Left Center WYSIWYG", Description = "WYSIWYG displayed in the center-left column of the footer", Order = 20, GroupName = TabNames.FOOTER)]
        public virtual XhtmlString LeftCenterWYSIWYG { get; set; }

        [CultureSpecific]
        [Display(Name = "Right Center WYSIWYG", Description = "WYSIWYG displayed in the center-right column of the footer", Order = 30, GroupName = TabNames.FOOTER)]
        public virtual XhtmlString RightCenterWYSIWYG { get; set; }

        [CultureSpecific]
        [Display(Name = "Right WYSIWYG", Description = "WYSIWYG displayed in the right column of the footer above the social icons", Order = 40, GroupName = TabNames.FOOTER)]
        public virtual XhtmlString RightWYSIWYG { get; set; }

        [Display(Name = "Facebook URL", Description = "Link you are taken to when clicking Facebook Icon", Order = 50, GroupName = TabNames.FOOTER)]
        public virtual Url FacebookUrl { get; set; }

        [Display(Name = "Twitter URL", Description = "Link you are taken to when clicking Twitter Icon", Order = 60, GroupName = TabNames.FOOTER)]
        public virtual Url TwitterUrl { get; set; }

        [Display(Name = "Instagram URL", Description = "Link you are taken to when clicking Instragram Icon", Order = 70, GroupName = TabNames.FOOTER)]
        public virtual Url InstagramUrl { get; set; }

        [CultureSpecific]
        [Display(Name = "Copyright Text", Description = "Copyright text displayed at the bottom of the footer", Order = 80, GroupName = TabNames.FOOTER)]
        [UIHint(UIHint.Textarea)]
        public virtual string CopyrightText { get; set; }

        [CultureSpecific]
        [Display(Name = "Footer Info Links", Description = "Displayed at the bottom of the footer", Order = 90, GroupName = TabNames.FOOTER)]
        public virtual XhtmlString FooterLinkArea { get; set; }
        #endregion

        #region Core Pages
        [Display(Name = "Search Results Page", Description = "Reference to the Search Results Page", Order = 100, GroupName = TabNames.CORE_PAGES)]
        public virtual PageReference SearchResultsPage { get; set; }
        #endregion
    }
}
