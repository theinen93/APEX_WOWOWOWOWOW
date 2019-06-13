using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ViewModelPartials.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks
{
    /// <summary>
    /// ViewModel for the Accordion Container Block
    /// </summary>
    public partial interface IAccordionContainerBlockViewModel : IBlockViewModel<AccordionContainerBlock>
    {
        /// <summary>
        /// The collection of items to be displayed in the accordion
        /// </summary>
        IEnumerable<AccordionViewItem> AccordionViewModelItems { get; }
    }
}
