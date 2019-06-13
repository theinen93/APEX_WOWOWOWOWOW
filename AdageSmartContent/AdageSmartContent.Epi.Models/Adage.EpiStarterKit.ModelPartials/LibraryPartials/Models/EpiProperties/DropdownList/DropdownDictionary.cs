using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.DropdownList
{
    /// <summary>
    /// Dictionaries used by Epi-Kit Dropdown Factories.  Sets base framework for default options and client overrides.
    /// </summary>
    public partial class DropdownDictionary : Dictionary<string, string>
    {
        #region Constructors
        public DropdownDictionary()
        {
            AddDefaultOptions();
            AddClientOptions();
        }
        #endregion

        #region Virtual Methods
        /// <summary>
        /// Adds the default options to the dictionary.
        /// </summary>
        /// <remarks>
        /// Generally implemented by the kit.  Client options should be added via "AddClientOptions"
        /// </remarks>
        public virtual void AddDefaultOptions()
        {
            // To be implemented by children in the kit
        }

        /// <summary>
        /// Adds client-specific options to the dictionary
        /// </summary>
        public virtual void AddClientOptions()
        {
            // To be implemented via partials in a client implementation
        }
        #endregion

    }
}
