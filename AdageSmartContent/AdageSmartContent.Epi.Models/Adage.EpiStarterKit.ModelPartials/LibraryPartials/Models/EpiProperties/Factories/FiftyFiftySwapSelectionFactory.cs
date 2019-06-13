using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.Factories
{
    public partial class FiftyFiftySwapSelectionFactory : EPiServer.Shell.ObjectEditing.ISelectionFactory
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            List<SelectItem> settings = new List<SelectItem>();

            settings.Add(new SelectItem() { Text = string.Empty, Value = "false" });
            settings.Add(new SelectItem() { Text = "Left Tile on top of Right Tile", Value = "false" });
            settings.Add(new SelectItem() { Text = "Right Tile on top of Left Tile", Value = "true" });

            return settings;
        }
    }
}
