using EPiServer;
using EPiServer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Models.Blocks
{
    public abstract partial class AdageBaseBlock : BlockData
    {
        /// <summary>
        /// Returns a Unique ID for the block, which may be useful for some JS purposes, eg Modals
        /// </summary>
        public virtual int ContentLinkID
        {
            get
            {
                return (this as IContent)?.ContentLink.ID ?? -1; // on-page blocks are not IContent
            }
        }

        /// <summary>
        /// Returns the name of the instance of the block
        /// </summary>
        public virtual string ContentName
        {
            get
            {
                return (this as IContent)?.Name ?? string.Empty;
            }
        }
    }
}
