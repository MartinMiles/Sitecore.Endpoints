using System;
using System.Linq;
using Sitecore.Feature.ServicesClient.Models;

namespace Sitecore.Feature.ServicesClient.Repositories
{
    public class EntityRespository : ICustomRepositoryActions<Entity>
    {
        public IQueryable<Entity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Entity FindById(string id)
        {
            throw new NotImplementedException();
        }

        public void Add(Entity entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entity entity)
        {
            throw new NotImplementedException();
        }

        public string DoSometingCustom()
        {
            return "Hello, World. I am a custom action";
        }
    }
}