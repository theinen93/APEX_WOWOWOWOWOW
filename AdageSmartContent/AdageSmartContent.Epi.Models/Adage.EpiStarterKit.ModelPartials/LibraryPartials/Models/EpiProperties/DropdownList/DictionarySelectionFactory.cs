using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.DropdownList
{
    public partial class DictionarySelectionFactory<T> : ISelectionFactory where T : Dictionary<string, string>
    {
        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var values = Activator.CreateInstance<T>();
            foreach (var value in values.ToList())
            {
                yield return new SelectItem()
                {
                    Value = value.Key.ToLower(),
                    Text = value.Value
                };
            }
        }
    }
}
