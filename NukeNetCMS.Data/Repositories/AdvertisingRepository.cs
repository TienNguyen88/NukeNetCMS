using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IAdvertisingRepository : IRepository<Advertising>
    {
    }

    public class AdvertisingRepository : RepositoryBase<Advertising>, IAdvertisingRepository
    {
        public AdvertisingRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}