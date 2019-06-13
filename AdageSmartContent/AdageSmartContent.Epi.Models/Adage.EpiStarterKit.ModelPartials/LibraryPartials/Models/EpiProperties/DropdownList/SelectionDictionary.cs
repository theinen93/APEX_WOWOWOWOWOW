using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.DropdownList
{
    public partial class SelectionDictionary
    {
        public partial class FiftyFiftyLayout : DropdownDictionary
        {
            public override void AddDefaultOptions()
            {
                Add(string.Empty, string.Empty);
                Add("libfiftyfifty-textleft", "Text On Left");
                Add("libfiftyfifty-textright", "Text On Right");
            }
        }

        public partial class SeoRobots : DropdownDictionary
        {
            public override void AddDefaultOptions()
            {
                Add(string.Empty, string.Empty);
                Add("INDEX, NO FOLLOW", "INDEX, NO FOLLOW");
                Add("NOINDEX, FOLLOW", "NOINDEX, FOLLOW");
                Add("NOINDEX, NO FOLLOW", "NOINDEX, NO FOLLOW");
            }
        }


        public partial class BackgroundColors : DropdownDictionary
        {
            public BackgroundColors()
            {
                Add(string.Empty, string.Empty);
                Add("adage-theme-light", "Light Theme");
                Add("adage-theme-dark", "Dark Theme");
            }
        }

        public partial class FiftyFiftyBackgroundColors : DropdownDictionary
        {
            public FiftyFiftyBackgroundColors()
            {
                Add(string.Empty, string.Empty);
                Add("adage-theme-light", "Light Theme");
                Add("adage-theme-dark", "Dark Theme");
            }
        }
    }
}
