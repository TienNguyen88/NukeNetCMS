using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IProductImageRepository
    {
    }

    public class ProductImageRepository : RepositoryBase<ProductImage>, IProductImageRepository
    {
        public ProductImageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}