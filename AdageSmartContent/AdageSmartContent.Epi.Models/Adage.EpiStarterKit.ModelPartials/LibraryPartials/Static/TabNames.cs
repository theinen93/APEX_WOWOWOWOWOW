using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Static
{
    [GroupDefinitions]
    public static partial class TabNames
    {
        [Display(GroupName = "Scripts", Order = 500)]
        public const string SCRIPTS = "Scripts";

        [Display(Order = 1000)]
        public const string SEO = "SEO";

        [Display(GroupName = "Settings", Order = 1100)]
        public const string SETTINGS = SystemTabNames.Settings;

        [Display(GroupName = "Core Pages", Order = 1100)]
        public const string CORE_PAGES = "Core Pages";

        [Display(GroupName = "Footer", Order = 1200)]
        public const string FOOTER = "Footer";
    }
}
