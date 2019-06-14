using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Models.Pages
{
    [ContentType(DisplayName = "ArticleDetailsPage", GUID = "2adb62c4-f499-45d1-867d-4c253fce930b", Description = "")]
    public class ArticleDetailsPage : AdageBasePage
    {
        [CultureSpecific]
        [Display(Name = "Article Title", Description = "Title that will appear at the top of the screen", Order = 100, GroupName = SystemTabNames.Content)]
        public virtual string ArticleTitle { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(Name = "Article Image", Description = "Image that will appear under the title", Order = 200, GroupName = SystemTabNames.Content)]
        public virtual Url Image { get; set; }

        [CultureSpecific]
        [Display(Name = "Author Byline", Description = "Byline of the author", Order = 300, GroupName = SystemTabNames.Content)]
        public virtual string AuthorByline { get; set; }

        [CultureSpecific]
        [Display(Name = "Author Publish Date", Description = "Date the article was published", Order = 400, GroupName = SystemTabNames.Content)]
        public virtual DateTime PublishDate { get; set; }

        [CultureSpecific]
        [Display(Name = "Introductory Paragraph", Description = "Short blurb of text to appear before the main content ", Order = 500, GroupName = SystemTabNames.Content)]
        public virtual XhtmlString IntroductoryParagraph { get; set; }

        [CultureSpecific]
        [Display(Name = "Body Content", Description = "Main content text", Order = 600, GroupName = SystemTabNames.Content)]
        public virtual XhtmlString BodyContent { get; set; }

        [CultureSpecific]
        [Display(Name = "References", Description = "List of links", Order = 700, GroupName = SystemTabNames.Content)]
        public virtual XhtmlString Refrences { get; set; }
    }
}
