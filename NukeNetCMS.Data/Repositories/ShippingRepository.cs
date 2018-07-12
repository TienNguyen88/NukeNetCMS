using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IShippingRepository
    {
    }

    public class ShippingRepository : RepositoryBase<Shipping>, IShippingRepository
    {
        public ShippingRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}