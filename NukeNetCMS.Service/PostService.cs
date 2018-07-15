using NukeNetCMS.Data.Infrastructure;
using NukeNetCMS.Data.Repositories;
using NukeNetCMS.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NukeNetCMS.Service
{
    public interface IPostService
    {
        Post Add(Post post);
        void Update(Post post);
        Post Delete(Post post);
        Post GetByID(int id);
        IEnumerable<Post> GetAllPaging(int page, int size, out int totalRow);
        IEnumerable<Post> GetTagAllPaging(string tagName, int page, int size, out int totalRow);
    }

    class PostService : IPostService
    {
        private IPostRepository _postRepository;
        private IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public Post Add(Post post)
        {
            return _postRepository.Add(post);
        }

        public Post Delete(Post post)
        {
            return _postRepository.Delete(post);
        }

        public IEnumerable<Post> GetAllPaging(int page, int size, out int totalRow)
        {
            return _postRepository.GetMultiPaging(null, out totalRow, page, size, new Expression<Func<Post, object>>[] { pc => pc.PostCategory, pt => pt.PostTags.Select(t => t.Tag) });
        }

        public Post GetByID(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public IEnumerable<Post> GetTagAllPaging(string tagName, int page, int size, out int totalRow)
        {
            return _postRepository.GetTagAllPaging(tagName, page, size, out totalRow);
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}
