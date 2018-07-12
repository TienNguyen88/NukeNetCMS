using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IContactRepository
    {
    }

    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        public ContactRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}