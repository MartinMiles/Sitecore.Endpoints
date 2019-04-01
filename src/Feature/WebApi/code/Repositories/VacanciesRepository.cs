using System.Collections.Generic;
using System.Linq;
using Sitecore.Feature.WebApi.Models;

namespace Sitecore.Feature.WebApi.Repositories
{
    public class VacanciesRepository : IRepository
    {
        private readonly List<Vacancy> _vacancies = new List<Vacancy>
        {
            new Vacancy { Title = "Account manager" },
            new Vacancy { Title = "Sitecore developer" },
        };

        public IQueryable<Vacancy> GetAll()
        {
            return _vacancies.AsQueryable();
        }
    }
}