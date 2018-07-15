using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IContactFieldRepository : IRepository<ContactField>
    {
    }

    public class ContactFieldRepository : RepositoryBase<ContactField>, IContactFieldRepository
    {
        public ContactFieldRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}