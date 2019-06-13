using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adage.EpiStarterKit.InitializationPartials
{
    /// <summary>
    /// Custom registrations for scanning for templates.  This ViewEngine allows us to set Property display overrides in the AdageViews folder.
    /// </summary>
    public partial class AdageKitViewEngine : RazorViewEngine
    {
        public AdageKitViewEngine()
        {
            PartialViewLocationFormats = PartialViewLocationFormats.Union(new[]
                                  {
                                    "~/Views/ClientViews/Shared/{0}.cshtml",
                                    "~/Views/AdageViews/Shared/{0}.cshtml",
                                  }).ToArray();
        }
    }
}