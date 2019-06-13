using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ModelPartials.Static;
using Adage.EpiStarterKit.ViewModelPartials.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks
{
    public partial class StaffInfoContainerBlockViewModel : BlockViewModel<StaffInfoContainerBlock>, IStaffInfoContainerViewModel
    {
        #region Constructors
        public StaffInfoContainerBlockViewModel(StaffInfoContainerBlock currentBlock) : base(currentBlock) { }
        #endregion

        #region IStaffInfoContainerViewModel Members
        private IEnumerable<StaffInfoViewItem> _staffInfoItems;
        public IEnumerable<StaffInfoViewItem> StaffInfoItems
        {
            get
            {
                if (_staffInfoItems == null)
                {
                    var filteredItems = CurrentBlock.StaffInfoContentArea.FilteredItemsOfTypeOrEmpty<StaffInfoItemBlock>();

                    _staffInfoItems = filteredItems.Select(item =>
                        new StaffInfoViewItem()
                        {
                            StaffImage = item.StaffImage,
                            StaffName = item.StaffName,
                            StaffInfo = item.StaffInfo,
                            StaffRole = item.StaffRole,
                            HideImage = CurrentBlock.HideStaffImages
                        }
                    );
                }
                return _staffInfoItems;
            }
        }
        #endregion
    }
}
