using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adage.EpiStarterKit.ViewModelPartials.ViewModels
{
    public partial class ViewModelFactory : IViewModelFactory
    {
        private IContainer Container;

        public ViewModelFactory(IContainer container)
        {
            this.Container = container;
        }

        /// <summary>
        /// Gets an instance of a view model based on the model type passed.
        /// </summary>
        /// <param name="modelType">A view model type to be crated by the DI container.  Can include nested generics.</param>
        /// <returns></returns>
        public object GetViewModel(Type viewType, Type modelType, object modelInstance = null)
        {
            var args = new StructureMap.Pipeline.ExplicitArguments();
            args.Set(modelType, modelInstance);
            var viewModel = Container.GetInstance(viewType, args);

            return viewModel;
        }
    }
}
