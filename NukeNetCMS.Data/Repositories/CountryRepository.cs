using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface ICountryRepository
    {
    }

    public class CountryRepository : RepositoryBase<Country>, ICountryRepository
    {
        public CountryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}