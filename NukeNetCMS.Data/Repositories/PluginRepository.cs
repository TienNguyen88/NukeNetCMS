using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IPluginRepository : IRepository<Plugin>
    {
    }

    public class PluginRepository : RepositoryBase<Plugin>, IPluginRepository
    {
        public PluginRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}