using System;
using System.ComponentModel.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.Static;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Adage.EpiStarterKit.ModelPartials.Models.Pages
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(ErrorPage), DisplayName = "Error Page", GroupName = ContentGroupNames.BasePages,
    GUID = "4603c377-4281-492e-bc7d-f5552e7f4296", Description = "A page which is displayed when the site throws an HTTP error")]
    [SiteImagesUrl("Page-Error.png")]
    public partial class ErrorPage : AdageBasePage
    {
        [CultureSpecific]
        [Display(
            Name = "Header",
            Description = "The header will be shown on the error page.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Sub-header",
            Description = "The sub-header will be shown on the error page.",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual string SubHeader { get; set; }

        [CultureSpecific]
        [Display(
            Name = "400 Code WYSIWYG ",
            Description = "The Wysiwyg content will be shown in the page when error code is 400.",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual XhtmlString Code400WYSIWYG { get; set; }

        [CultureSpecific]
        [Display(
            Name = "401 Code WYSIWYG",
            Description = "The Wysiwyg content will be shown in the page when error code is 401.",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual XhtmlString Code401WYSIWYG { get; set; }

        [CultureSpecific]
        [Display(
            Name = "403 Code WYSIWYG",
            Description = "The Wysiwyg content will be shown in the page when error code is 403.",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual XhtmlString Code403WYSIWYG { get; set; }

        [CultureSpecific]
        [Display(
            Name = "404 Code WYSIWYG",
            Description = "The Wysiwyg content will be shown in the page when error code is 404.",
            GroupName = SystemTabNames.Content,
            Order = 60)]
        public virtual XhtmlString Code404WYSIWYG { get; set; }

        [CultureSpecific]
        [Display(
            Name = "500 Code WYSIWYG",
            Description = "The Wysiwyg content will be shown in the page when error code is 500.",
            GroupName = SystemTabNames.Content,
            Order = 70)]
        public virtual XhtmlString Code500WYSIWYG { get; set; }

        [CultureSpecific]
        [Display(
            Name = "General Error WYSIWYG",
            Description = "The Wysiwyg content will be shown in the page when error is not caught by codes above.",
            GroupName = SystemTabNames.Content,
            Order = 80)]
        public virtual XhtmlString GeneralErrorWYSIWYG { get; set; }
    }
}