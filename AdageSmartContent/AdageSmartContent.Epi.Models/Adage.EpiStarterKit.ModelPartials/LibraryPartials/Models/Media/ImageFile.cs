using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.Models.Media
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(ImageFile), DisplayName = "Image File",
             GUID = "a4814493-9562-4c2d-bd17-0aaf6647cdcd",
             Description = "Image File")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png,svg")]
    public partial class ImageFile : ImageData
    {
        [Display(Name = "Alt Text", Order = 100)]
        public virtual string AltText { get; set; }

        [Display(Name = "Gallery Caption", Order = 200)]
        public virtual string GalleryCaption { get; set; }
    }
}
