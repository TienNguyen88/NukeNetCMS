using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace NukeNetCMS.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
        IEnumerable<Post> GetTagAllPaging(string tagName, int page, int size, out int totalRow);
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Post> GetTagAllPaging(string tagName, int page, int size, out int totalRow)
        {
            IQueryable<Post> query = DbContext.Posts
                .Join(DbContext.PostTags,
                    p => p.ID,
                    pt => pt.PostID,
                    (p, pt) => new
                    {
                        Posts = p,
                        TagId = pt.TagID
                    })
                .Join(DbContext.Tags.Where(t => t.Name == tagName),
                    pt => pt.TagId,
                    t => t.ID,
                    (pt, t) => pt.Posts);
            totalRow = query.Count();
            return query = query.Skip((page - 1) * size).Take(size);
        }
    }
}