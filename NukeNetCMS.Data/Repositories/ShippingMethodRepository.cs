using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IShippingMethodRepository : IRepository<ShippingMethod>
    {
    }

    public class ShippingMethodRepository : RepositoryBase<ShippingMethod>, IShippingMethodRepository
    {
        public ShippingMethodRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}