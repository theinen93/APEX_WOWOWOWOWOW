using Adage.EpiStarterKit.ModelPartials.BusObj;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels.Pages;
using Adage.EpiStarterKit.ViewModelPartials.BusObj;
using StructureMap;
using StructureMap.Graph;
using Adage.EpiStarterKit.ModelPartials.Models.Blocks;

namespace Adage.EpiStarterKit.InitializationPartials
{
    public partial class AdageEpiStarterKitRegistry : Registry
    {
        public AdageEpiStarterKitRegistry()
        {
            Scan(x =>
            {
                // Add the assemblies we are doing DI in
                x.TheCallingAssembly();
                AddRemainingAssemblies(x);

                // registers the default convention (ISomething to Something)
                x.WithDefaultConventions();

                x.ConnectImplementationsToTypesClosing(typeof(IPageViewModel<>));
                x.ConnectImplementationsToTypesClosing(typeof(IBlockViewModel<>));
                x.ConnectImplementationsToTypesClosing(typeof(IBaseLinkBlockViewModel<>));
            });

            RegisterOtherTypes();

            For(typeof(IPageViewModel<>)).Use(typeof(PageViewModel<>));
            For(typeof(IBlockViewModel<>)).Use(typeof(BlockViewModel<>));
            For(typeof(IViewModelFactory)).Use(typeof(ViewModelFactory));
            For(typeof(IErrorPageViewModel)).Use(typeof(ErrorPageViewModel));
            For(typeof(IBaseLinkBlockViewModel<>)).Use(typeof(BaseLinkBlockViewModel<>));
            For(typeof(ISiteDataRepository)).Use(typeof(SiteDataRepository));
            For(typeof(ISiteNavigationRepository)).Use(typeof(SiteNavigationRepository));
            For(typeof(IOpenGraphService)).Use(typeof(OpenGraphService));
            For(typeof(ISEOService)).Use(typeof(SEOService));
            For(typeof(IBreadcrumbService)).Use(typeof(BreadcrumbService));

            For(typeof(IBlockViewModel<FiftyFiftyBlock>)).Use(typeof(FiftyFiftyBlockViewModel));
            For(typeof(IBlockViewModel<AccordionContainerBlock>)).Use(typeof(AccordionContainerBlockViewModel));
            For(typeof(IBlockViewModel<StaffInfoContainerBlock>)).Use(typeof(StaffInfoContainerBlockViewModel));
            For(typeof(IBlockViewModel<VideoBlock>)).Use(typeof(VideoBlockViewModel));

        }
        partial void AddRemainingAssemblies(IAssemblyScanner scanner);
        partial void RegisterOtherTypes();
    }
}