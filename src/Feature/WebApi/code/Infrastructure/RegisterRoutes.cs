using System.Web.Mvc;
using System.Web.Routing;
using Sitecore.Pipelines;

namespace Sitecore.Feature.WebApi.Infrastructure
{
    public class RegisterRoutes
    {
        public void Process(PipelineArgs args)
        {
            RouteTable.Routes.MapRoute("Sitecore.Feature.WebApi", "api/vacancies/{action}", new
            {
                controller = "Vacancies"
            });
        }
    }
}