using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IAreaRepository
    {
    }

    public class AreaRepository : RepositoryBase<Area>, IAreaRepository
    {
        public AreaRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}