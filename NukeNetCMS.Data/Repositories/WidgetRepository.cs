using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IWidgetRepository : IRepository<Widget>
    {
    }

    public class WidgetRepository : RepositoryBase<Widget>, IWidgetRepository
    {
        public WidgetRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}