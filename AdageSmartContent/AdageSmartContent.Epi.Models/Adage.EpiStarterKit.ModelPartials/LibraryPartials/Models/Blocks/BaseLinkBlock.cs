using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.Models.EpiProperties.Factories;
using EPiServer;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    /// <summary>
    /// Base block for all blocks which represent a clickable anchor tag
    /// </summary>
    public abstract partial class BaseLinkBlock : AdageBaseBlock
    {
        [CultureSpecific]
        [Display(
            Name = "Url",
            Description = "The Link Url",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual Url LinkUrl { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Target Frame",
            Description = "Determines whether the tab should open in a new window or the same window",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        [UIHint(AdagePageTargetFrameSelectionFactory.UIHINT)]
        public virtual int? TargetFrameRaw { get; set; }
    }
}
