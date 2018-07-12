using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IProductCategoryRepository
    {
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}