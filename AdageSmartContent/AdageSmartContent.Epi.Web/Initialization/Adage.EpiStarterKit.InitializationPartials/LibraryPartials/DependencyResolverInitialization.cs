using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using StructureMap;
using System;
using System.Web.Mvc;

namespace Adage.EpiStarterKit.InitializationPartials
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public partial class DependencyResolverInitialization : IConfigurableModule
    {
        /// <summary>
        /// Configures the container
        /// </summary>
        /// <param name="context">EPiServer service configuration context</param>
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            // EPiServer.ServiceLocation.StructureMap.2.0.0\lib\net461\EPiServer.ServiceLocation.StructureMap.dll
            // use the episerver extension: EPiServer.ServiceLocation.ServiceConfigurationContextExtensions.StructureMap()
            var container = context.StructureMap();

            if (container == null)
            {
                string message = "ServiceConfigurationContext.StructureMap() returned null. StructureMapDependencyResolver cannot be initialized.";
                throw new InvalidOperationException(message);
            }

            container.Configure(ConfigureContainer);

            // set resolver
            DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));
        }

        /// <summary>
        /// Initializes the instance.
        /// </summary>
        public void Initialize(InitializationEngine context)
        {
        }

        /// <summary>
        /// Uninitializes the instance.
        /// </summary>
        public void Uninitialize(InitializationEngine context)
        {
        }

        /// <summary>
        /// Not implemented.
        /// </summary>
        public void Preload(string[] parameters)
        {
        }

        private static void ConfigureContainer(ConfigurationExpression container)
        {
            container.IncludeRegistry<AdageEpiStarterKitRegistry>();
        }
    }
}