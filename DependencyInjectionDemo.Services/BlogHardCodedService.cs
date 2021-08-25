using System;
using System.Collections.Generic;
using System.Linq;
using DependencyInjectionDemo.Data;
using DependencyInjectionDemo.Models;

namespace DependencyInjectionDemo.Services
{
    public class BlogHardCodedService
    {
        public List<Post> GetAllPosts()
        {
            var blogData = new HardCodedData();

            return blogData.Posts();
        }

        public Post GetPost(int id)
        {
            var blogData = new HardCodedData();
            return blogData.Posts().SingleOrDefault(p => p.Id == id);
        }
    }
}
