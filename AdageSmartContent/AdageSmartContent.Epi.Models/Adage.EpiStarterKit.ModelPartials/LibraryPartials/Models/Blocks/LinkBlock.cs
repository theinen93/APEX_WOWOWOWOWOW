using Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.Factories;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(LinkBlock), DisplayName = "Link Block", GUID = "123fc8c6-d324-425a-a7ee-08b3a3ce749f",
       Description = "Url/Text combination used to represent links or buttons. Backend block only.", AvailableInEditMode = false)]
    public partial class LinkBlock : BaseLinkBlock
    {
        [CultureSpecific]
        [Display(
            Name = "Text",
            Description = "Leave blank to hide the button",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual String LinkText { get; set; }
    }
}
