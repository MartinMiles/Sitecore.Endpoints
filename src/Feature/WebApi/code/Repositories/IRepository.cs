using System.Linq;
using Sitecore.Feature.WebApi.Models;

namespace Sitecore.Feature.WebApi.Repositories
{
    public interface  IRepository
    {
        IQueryable<Vacancy> GetAll();
    }
}