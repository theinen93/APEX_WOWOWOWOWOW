using Adage.EpiStarterKit.ModelPartials.Models.Blocks;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels.Blocks;
using EPiServer;
using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adage.EpiStarterKit.ControllerPartials.Base
{
    public partial class AdageBaseBlockController<T> : BlockController<T> where T : AdageBaseBlock
    {
        protected IViewModelFactory ViewModelFactory { get; set; }
        protected virtual string RootFileName { get; } = "{0}/{1}View.cshtml";
        protected virtual string AdageViewsRoot { get; } = "~/Views/AdageViews/Blocks";
        protected virtual string ClientViewsRoot { get; } = "~/Views/ClientViews/Blocks";

        public AdageBaseBlockController(IViewModelFactory viewModelFactory)
        {
            this.ViewModelFactory = viewModelFactory;
        }

        /// <summary>
        /// Default block handler.
        /// </summary>
        /// <param name="currentBlock">Any block of type CarboniteBlockBase.</param>
        /// <returns></returns>
        public override ActionResult Index(T currentBlock)
        {
            var model = CreateDefaultBlockViewModel(currentBlock);
            return View(GetViewLocation(currentBlock), model);
        }

        protected object CreateDefaultBlockViewModel(T currentBlock)
        {
            var type = typeof(IBlockViewModel<>).MakeGenericType(currentBlock.GetOriginalType());
            var modelType = currentBlock.GetOriginalType();
            return ViewModelFactory.GetViewModel(type, modelType, currentBlock);
        }

        protected virtual V CreateBlockViewModel<V>(T block) where V : class
        {
            var viewType = typeof(V);
            var modelType = block.GetOriginalType();
            var viewModel = ViewModelFactory.GetViewModel(viewType, modelType, block);
            return viewModel as V;
        }

        protected virtual string GetViewLocation(T currentBlock)
        {
            var blockName = GetBlockName(currentBlock);
            var adageViewLocation = string.Format(RootFileName, AdageViewsRoot, blockName);
            var clientViewLocation = string.Format(RootFileName, ClientViewsRoot, blockName);
            if (System.IO.File.Exists(Server.MapPath(clientViewLocation)))
                return clientViewLocation;
            else
                return adageViewLocation;
        }

        protected virtual string GetBlockName(T currentBlock)
        {
            return currentBlock.GetOriginalType().Name;
        }
    }
}