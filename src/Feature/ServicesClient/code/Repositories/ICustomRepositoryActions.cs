using Sitecore.Services.Core;

namespace Sitecore.Feature.ServicesClient.Repositories
{
    public interface ICustomRepositoryActions<T> : IRepository<T> where T : IEntityIdentity
    {
        string DoSometingCustom();
    }
}
