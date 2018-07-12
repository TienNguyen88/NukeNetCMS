using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IControlRepository
    {
    }

    public class ControlRepository : RepositoryBase<Control>, IControlRepository
    {
        public ControlRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}