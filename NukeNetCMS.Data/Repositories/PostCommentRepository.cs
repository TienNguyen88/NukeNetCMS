using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Model.Models;

namespace NukeNetCMS.Data.Repositories
{
    public interface IPostCommentRepository
    {
    }

    public class PostCommentRepository : RepositoryBase<PostComment>, IPostCommentRepository
    {
        public PostCommentRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}