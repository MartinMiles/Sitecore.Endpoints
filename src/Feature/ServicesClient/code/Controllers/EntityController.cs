using System.Web.Http;
using Sitecore.Services.Core;
using Sitecore.Services.Infrastructure.Sitecore.Services;
using Sitecore.Feature.ServicesClient.Models;
using Sitecore.Feature.ServicesClient.Repositories;

namespace Sitecore.Feature.ServicesClient.Controllers
{
    // this will be called with a routing by default:  {Controller-Namespace}/{Controller}/{ID}/{CustomActionName}
    // http://YOUR_SITECORE_HOSTNAME/sitecore/api/ssc/Sitecore-Feature-ServicesClient/Entity/1/DoSomethingCustom

    [ServicesController]
    public class EntityController : EntityService<Entity>
    {
        private readonly ICustomRepositoryActions<Entity> _customRepositoryActions;

        public EntityController(ICustomRepositoryActions<Entity> repository) : base(repository)
        {
            _customRepositoryActions = repository;
        }

        public EntityController() : this(new EntityRespository())
        {
        }


        [HttpGet]
        [ActionName("DoSomethingCustom")]
        public string Get()
        {
            return _customRepositoryActions.DoSometingCustom();
        }
    }
}