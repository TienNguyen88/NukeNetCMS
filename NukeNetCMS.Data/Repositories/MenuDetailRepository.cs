using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IMenuDetailRepository
    {
    }

    public class MenuDetailRepository : RepositoryBase<MenuDetail>, IMenuDetailRepository
    {
        public MenuDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}