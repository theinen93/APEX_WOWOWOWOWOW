using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.Pocos
{
    public partial class StaffInfoViewItem
    {
        /// <summary>
        /// Name of the staff Member
        /// </summary>
        public string StaffName { get; set; }

        /// <summary>
        /// Role of the staff member
        /// </summary>
        public string StaffRole { get; set; }

        /// <summary>
        /// Information about the Staff member
        /// </summary>
        public XhtmlString StaffInfo { get; set; }

        /// <summary>
        /// Image of staff member
        /// </summary>
        public ImageBlock StaffImage { get; set; }

        /// <summary>
        /// Detemines if image should be displayed. pulled from StaffInfoContainer block
        /// </summary>
        public bool HideImage { get; set; }
    }
}
