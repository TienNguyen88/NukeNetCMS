using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface ISlideRepository
    {
    }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}