using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyInjectionDemo.Models;

namespace DependencyInjectionDemo.Data
{
    public class HardCodedData
    {
        public List<Post> Posts()
        {
            var posts = new List<Post>();

            posts.Add(new Post()
            {
                Id = 1,
                UserId = 1,
                Title = "sunt aut facere repellat",
                Body =
                    "quia et suscipit suscipit recusandae consequuntur expedita et cum reprehenderit molestiae ut ut quas totam nostrum rerum est autem sunt rem eveniet architecto"
            });

            posts.Add(new Post()
            {
                Id = 2,
                UserId = 1,
                Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                Body =
                    "quia et suscipit suscipit recusandae consequuntur expedita et cum reprehenderit molestiae ut ut quas totam nostrum rerum est autem sunt rem eveniet architecto"
            });

            posts.Add(new Post()
            {
                Id = 3,
                UserId = 1,
                Title = "sunt aut facere repellat provident ",
                Body =
                    "quia et suscipit suscipit recusandae consequuntur expedita et cum rt ut quas totam nostrum rerum est autem sunt rem eveniet architecto"
            });

            posts.Add(new Post()
            {
                Id = 4,
                UserId = 1,
                Title = "sunt aut facere repellat optio reprehenderit",
                Body =
                    "quia et suscipit suscipit recusandae consequuntur expedita et cum reprehenderit molestiae ut ut quas totam nostrum rerum est autem sunt rem eveniet architecto"
            });

            posts.Add(new Post()
            {
                Id = 5,
                UserId = 1,
                Title = "sunt aut facere repellat pt",
                Body =
                    "quia et suscipit suscipit recusandae consequuntur expedita et cum reprehenderit molestiae ut ut quas totam nostrum rerum est autem sunt rem eveniet architecto"
            });

            posts.Add(new Post()
            {
                Id = 6,
                UserId = 1,
                Title = "excepturi optio reprehenderit",
                Body = "quia et suscipit suscipit recusandae con"
            });

            posts.Add(new Post()
            {
                Id = 7,
                UserId = 1,
                Title = "sunt aut facere reppturi optio reprehenderit",
                Body = "quia et suscipit suscipit recusandae coe ut ut quas totam nostrum rerum est autem sunt rem eveniet architecto"
            });

            posts.Add(new Post()
            {
                Id = 8,
                UserId = 1,
                Title = "sunt aut excepturi optio reprehenderit",
                Body = "quia et suscipit suscipit recusandae c"
            });

            posts.Add(new Post()
            {
                Id = 9,
                UserId = 1,
                Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                Body = "quia et suscipit suscipit recusandae consequunturehenderit molestiae ut ut quas totam nostrum rerum est autem sunt rem eveniet architecto"
            });

            posts.Add(new Post()
            {
                Id = 10,
                UserId = 1,
                Title = "sunt aut facere repellat optio reprehenderit",
                Body = "quia et suscipit suscipit recusandae consequuntur expedita et cum reprehenderit molestiae ut ut quas totam nostrum rerum est autem sunt rem eveniet architecto"
            });

            return posts;
        }
    }
}

