using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System.Configuration;
using EPiServer.ServiceLocation;
using EPiServer.DataAbstraction;
using Adage.EpiStarterKit.ControllerPartials.Base;
using Adage.EpiStarterKit.ModelPartials.Models.Pages;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels;
using Adage.EpiStarterKit.ViewModelPartials.ViewModels.Pages;

namespace Adage.EpiStarterKit.ControllerPartials.Pages
{
    public partial class AdageErrorPageController : AdageBasePageController<ErrorPage>
    {
        public AdageErrorPageController(IViewModelFactory viewModelFactory) : base(viewModelFactory)
        {
        }

        /// <summary>
        /// Index Method of the controller
        /// </summary>
        /// <param name="currentPage"></param>
        /// <returns></returns>
        public override ActionResult Index(ErrorPage currentPage)
        {
            if (currentPage == null)
                currentPage = GetAllPagesOfType<ErrorPage>().FirstOrDefault();

            if (currentPage != null)
            {
                int errorCode = 500;
                int.TryParse(Request.QueryString["code"], out errorCode);
                var model = CreatePageViewModel<IErrorPageViewModel>(currentPage);
                model.SetErrorCode(errorCode);
                return View(GetViewLocation(currentPage), model);
            }
            return null;
        }


        protected IEnumerable<T> GetAllPagesOfType<T>(PageReference startPage = null)
        {
            startPage = startPage == null ? ContentReference.StartPage : startPage;
            var contentTypeRepository = ServiceLocator.Current.GetInstance<IContentTypeRepository>();
            PropertyCriteriaCollection criterias = new PropertyCriteriaCollection {
                new PropertyCriteria ()
                {
                    Name = "PageTypeID",
                    Type = PropertyDataType.PageType,
                    Condition = EPiServer.Filters.CompareCondition.Equal,
                    Value = contentTypeRepository.Load<T>().ID.ToString()
                }
            };

            var pageCriteriaQueryService = ServiceLocator.Current.GetInstance<IPageCriteriaQueryService>();
            return pageCriteriaQueryService.FindPagesWithCriteria(startPage, criterias).Cast<T>();
        }
    }
}