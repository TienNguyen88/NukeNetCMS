using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface ITemplateRepository
    {
    }

    public class TemplateRepository : RepositoryBase<Template>, ITemplateRepository
    {
        public TemplateRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}