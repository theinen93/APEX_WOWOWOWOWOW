using System;
using System.ComponentModel.DataAnnotations;
using Adage.EpiStarterKit.ModelPartials.Static;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Adage.EpiStarterKit.ModelPartials.Models.Pages
{
    [LibraryPartials.Static.StarterKitContentTypeAttribute(CurrentType: typeof(MegaNavPage),
        DisplayName = "Mega Navigation Page", GroupName = ContentGroupNames.BasePages,
        GUID = "c5cc60b1-739b-4ac4-8ed8-131055d07e43", Description = "A page that will appear as an item in the Mega Nav")]
    [SiteImagesUrl("Page-Mega-Navigation.png")]
    public partial class MegaNavPage : ContainerPage, IContainerPage
    {
    }
}