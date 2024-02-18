using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace TinyBlog.Models.Services
{
    public class ClientBlogPostService : IBlogPostService
    {
        private readonly HttpClient http;

        public ClientBlogPostService(HttpClient http)
        {
            this.http = http;
        }
        public async Task<int> CreateBlogPostAsync(BlogPost blogPost)
        {
            var result = await http.PostAsJsonAsync("/api/blogpost", blogPost);
            return await result.Content.ReadFromJsonAsync<int>();
        }

        public async Task<int> DeleteBlogPostAsync(int id)
        {
            var result = await http.DeleteAsync($"/api/blogpost{id}");
            return await result.Content.ReadFromJsonAsync<int>();
        }

        public async Task<List<BlogPost>> GetAllPostsAsync()
        {
            var result = await http.GetFromJsonAsync<List<BlogPost>>("api/blogpost");
            return result;
        }

        public async Task<BlogPost> GetBlogPostByIdAsync(int id)
        {
            var result = await http.GetFromJsonAsync<BlogPost>($"api/blogpost/{id}");
            return result;
        }

        public async Task<int> UpdateBlogPostAsync(int id, BlogPost blogPost)
        {
            var result = await http.PutAsJsonAsync($"/api/blogpost/{id}", blogPost);
            return await result.Content.ReadFromJsonAsync<int>();
        }
    }
}
