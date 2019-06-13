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
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(DocumentFile), DisplayName = "Document File",
        GUID = "a48aaa93-9562-4c2d-bd17-0aafaa47cdcd",
        Description = "Document File")]
    [MediaDescriptor(ExtensionString = "xls,xlsx,doc,docx,ppt,pptx,pdf")]
    public partial class DocumentFile : MediaData
    {
        public virtual string Description { get; set; }

        public virtual string Copyright { get; set; }
    }
}
