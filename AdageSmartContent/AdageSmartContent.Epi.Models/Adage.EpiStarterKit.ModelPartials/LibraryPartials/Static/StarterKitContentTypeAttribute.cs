using EPiServer.DataAnnotations;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.LibraryPartials.Static
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public partial class StarterKitContentTypeAttribute : ContentTypeAttribute
    {
        static ConcurrentDictionary<Type, PartialContentTypeAttribute> partialContentTypeDict = new ConcurrentDictionary<Type, PartialContentTypeAttribute>();
        public StarterKitContentTypeAttribute(Type CurrentType) : base()
        {
            // look to see if there is a partial atttribute on this type as well
            PartialContentTypeAttribute partialContentType;

            // Look to see if we have already gotten the custom attribute for this type
            if (partialContentTypeDict.TryGetValue(CurrentType, out partialContentType) == false)
            {
                partialContentType = System.Attribute.GetCustomAttribute(CurrentType, typeof(PartialContentTypeAttribute)) as PartialContentTypeAttribute;
                partialContentTypeDict.TryAdd(CurrentType, partialContentType);
            }

            // if there is a partial attribute then pull the data from it in the Epi content type
            if (partialContentType != null)
            {
                AvailableInEditMode = partialContentType.AvailableInEditMode ?? AvailableInEditMode;
                Description = partialContentType.Description ?? Description;
                GroupName = partialContentType.GroupName ?? GroupName;
                DisplayName = partialContentType.DisplayName ?? DisplayName;
                GUID = partialContentType.GUID ?? GUID;
            }
        }
    }
}
