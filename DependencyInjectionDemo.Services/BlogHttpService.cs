using DependencyInjectionDemo.Models;
using DependencyInjectionDemo.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Services
{
    public class BlogHttpService : IBlogService
    {
        List<Post> IBlogService.GetAllPosts()
        {
            throw new NotImplementedException();
        }

        Post IBlogService.GetPost(int id)
        {
            throw new NotImplementedException();
        }
    }
}
