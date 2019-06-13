using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Models.Media
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(VideoFile), DisplayName = "Video File",
        GUID = "aaaa43b5-29c5-4bb5-95a6-5aee053a0dea",
        Description = "Video File")]
    [MediaDescriptor(ExtensionString = "flv,mp4,mov")]
    public partial class VideoFile : VideoData
    {
        public virtual string Description { get; set; }

        public virtual string Copyright { get; set; }
    }
}
