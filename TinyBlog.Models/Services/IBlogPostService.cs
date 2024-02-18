using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyBlog.Models.Services
{
    public interface IBlogPostService
    {
        Task<List<BlogPost>> GetAllPostsAsync();
        Task<BlogPost> GetBlogPostByIdAsync(int id);
        Task<int> CreateBlogPostAsync(BlogPost blogPost);
        Task<int> UpdateBlogPostAsync(int id, BlogPost blogPost);
        Task<int> DeleteBlogPostAsync(int id);
    }
}
