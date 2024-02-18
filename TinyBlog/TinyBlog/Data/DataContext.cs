using Microsoft.EntityFrameworkCore;
using TinyBlog.Models;


namespace TinyBlog.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
