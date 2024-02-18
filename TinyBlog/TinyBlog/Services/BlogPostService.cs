using TinyBlog.Models;
using TinyBlog.Models.Services;

namespace TinyBlog.Services
{
    public class BlogPostService : IBlogPostService
    {
        public Task<int> CreateBlogPostAsync(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteBlogPostAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BlogPost>> GetAllPostsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BlogPost> GetBlogPostByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateBlogPostAsync(int id, BlogPost blogPost)
        {
            throw new NotImplementedException();
        }
    }
}
