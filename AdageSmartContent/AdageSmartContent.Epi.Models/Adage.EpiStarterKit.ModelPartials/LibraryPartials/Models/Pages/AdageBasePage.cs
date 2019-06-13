using Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.DropdownList;
using Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.Factories;
using Adage.EpiStarterKit.ModelPartials.Static;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Models.Pages
{
    public abstract partial class AdageBasePage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "SEO Title",
            Description = "The title of the page",
            GroupName = TabNames.SEO,
            Order = 1000)]
        public virtual string SEOTitle { get; set; }

        [UIHint(UIHint.Textarea)]
        [CultureSpecific]
        [Display(
            Name = "Keywords",
            Description = "Keywords for the page",
            GroupName = TabNames.SEO,
            Order = 2000)]
        public virtual string SEOKeywords { get; set; }

        [UIHint(UIHint.Textarea)]
        [CultureSpecific]
        [Display(
            Name = "Description",
            Description = "Description of the page. Values entered here should be comma-separated",
            GroupName = TabNames.SEO,
            Order = 3000)]
        public virtual string SEODescription { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Robots",
            Description = "How web robots should handle the page",
            GroupName = TabNames.SEO,
            Order = 4000)]
        [EditorDescriptor(EditorDescriptorType = typeof(DictionaryEditorDescriptor<SelectionDictionary.SeoRobots>))]
        public virtual string SEORobots { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        [Display(
            Name = "Head Script",
            Description = "Used to place web scripts right before the closure of the head tag",
            GroupName = TabNames.SEO,
            Order = 5000)]
        public virtual string Script { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Textarea)]
        [Display(
            Name = "OG:Description",
            Description = "Description of the page that will be value of og:description tag",
            GroupName = TabNames.SEO,
            Order = 6000)]
        public virtual string OGDescription { get; set; }

        [CultureSpecific]
        [UIHint(UIHint.Image)]
        [Display(Name = "OG:Image",
            Description = "Image that will be value of og:image tag",
            GroupName = TabNames.SEO,
            Order = 7000)]
        public virtual Url OGImage { get; set; }
    }
}
