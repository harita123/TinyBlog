using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TinyBlog.Models.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//http client
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});

builder.Services.AddScoped<IBlogPostService, ClientBlogPostService>();

await builder.Build().RunAsync();
