using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adage.EpiStarterKit.ModelPartials.Static;
using Adage.EpiStarterKit.ViewModelPartials.Pocos;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks
{
    public partial class AccordionContainerBlockViewModel : BlockViewModel<AccordionContainerBlock>, IAccordionContainerBlockViewModel
    {
        #region Constructors
        public AccordionContainerBlockViewModel(AccordionContainerBlock currentBlock) : base(currentBlock)
        {
        }
        #endregion

        #region IAccordionContainerBlockViewModel Members
        protected IEnumerable<AccordionViewItem> _accordionViewItem;
        public IEnumerable<AccordionViewItem> AccordionViewModelItems
        {
            get
            {
                if (_accordionViewItem == null)
                {
                    var filteredItems = CurrentBlock.AccordionContentArea.FilteredItemsOfTypeOrEmpty<AccordionItemBlock>();

                    _accordionViewItem = filteredItems.Select(item =>
                        new AccordionViewItem()
                        {
                            Title = item.Title,
                            Content = item.AccordionContent,
                            ClientID = $"accordion_{Guid.NewGuid()}"
                        }
                    );
                }

                return _accordionViewItem;
            }
        }
        #endregion
    }
}
