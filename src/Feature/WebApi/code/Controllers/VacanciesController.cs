using System.Web.Mvc;
using Sitecore.Feature.WebApi.Repositories;

namespace Sitecore.Feature.WebApi.Controllers
{
    // to be called as: http://YOUR_SITECORE_HOSTNAME/api/vacancies/get
    // that is set at RouteConfig wihin Infrastructure folder

    public class VacanciesController : Controller
    {
        private readonly IRepository _repository;

        public VacanciesController(IRepository repository)
        {
            _repository = repository;
        }

        //[HttpPost]
        //[SkipAnalyticsTracking] - please reference Sitecore.Foundation.Extensions in order to use this attribute
        public JsonResult Get()
        {
            _repository.GetAll();
            return new JsonResult {Data = _repository.GetAll(), JsonRequestBehavior = JsonRequestBehavior.AllowGet};
        }
    }
}