using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DependencyInjectionDemo.Models;
using DependencyInjectionDemo.Shared;
using Newtonsoft.Json;

namespace DependencyInjectionDemo.Services
{
    public class BlogHttpService : IBlogService
    {
        private readonly HttpClient _httpClient;
        private List<Post> _posts;
        private Post _post;

        public BlogHttpService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _posts = new List<Post>();
            _post = new Post();
        }

        public List<Post> GetAllPosts()
        {
            Task.Run(GetPosts).Wait();
            return _posts;
        }

        public Post GetPost(int id)
        {
            Task.Run(() => OnePost(id)).Wait();
            return _post;
        }

        private async Task GetPosts()
        {
            var response = await _httpClient.GetAsync("/posts");
            
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                _posts = JsonConvert.DeserializeObject<List<Post>>(content);
            }
        }

        private async Task OnePost(int id)
        {
            var response = await _httpClient.GetAsync($"/posts/{id}");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                _post = JsonConvert.DeserializeObject<Post>(content);
            }
        }
    }
}
