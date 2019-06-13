using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using EPiServer.Cms.TinyMce.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adage.EpiStarterKit.InitializationPartials
{
    [ModuleDependency(typeof(TinyMceInitialization))]
    public partial class ExtendedTinyMceInitialization : IConfigurableModule
    {
        public const string LIMITED_TOOLBAR_OPTIONS = "bold italic underline epi-link";
        public const string ITALICS_ONLY_TOOLBAR_OPTIONS = "italic";
        public const string STYLE_ONLY_TOOLBAR_OPTIONS = "bold italic underline";

        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            var toolBarOptions = "formatselect | epi-personalized-content epi-link anchor numlist bullist " +
                                "indent outdent bold italic underline alignleft aligncenter alignright | " +
                                "image epi-image-editor media code | epi-dnd-processor | removeformat | fullscreen | styleselect";

            context.Services.Configure<TinyMceConfiguration>(config =>
            {
                var limitedWYSIWYGConfiguration = config.Default().Clone().Toolbar(LIMITED_TOOLBAR_OPTIONS);

                var styleOnlyConfiguration = config.Default().Clone().Toolbar(STYLE_ONLY_TOOLBAR_OPTIONS);

                config.For<ContentHighlightItemBlock>(a => a.TextArea, styleOnlyConfiguration);

                config.For<SiteSettingsPage>(a => a.FooterLinkArea, limitedWYSIWYGConfiguration);

                config.Default()
                    .AddPlugin("media wordcount anchor code")
                    .Toolbar(toolBarOptions)
                    .AddSetting("image_caption", true)
                    .AddSetting("image_advtab", true);
            });

            ClientCustomizations(context);
        }


        partial void ClientCustomizations(ServiceConfigurationContext context);

    }

}