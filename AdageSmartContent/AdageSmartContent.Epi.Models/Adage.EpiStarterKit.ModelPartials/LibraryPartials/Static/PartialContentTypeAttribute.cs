using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ModelPartials.LibraryPartials.Static
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public partial class PartialContentTypeAttribute : Attribute
    {
        public PartialContentTypeAttribute(bool? AvailableInEditMode = null, string Description = null, string GroupName = null, string DisplayName = null, string GUID = null) : base()
        {
            this.AvailableInEditMode = AvailableInEditMode;
            this.Description = Description;
            this.GroupName = GroupName;
            this.DisplayName = DisplayName;
            this.GUID = GUID;
        }

        public bool? AvailableInEditMode { get; set; }
        public string Description { get; set; }
        public string GroupName { get; set; }
        public string DisplayName { get; set; }
        public string GUID { get; set; }
    }
}
