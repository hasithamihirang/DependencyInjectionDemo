using DependencyInjectionDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionDemo.Services;
using DependencyInjectionDemo.Web.Models;
using DependencyInjectionDemo.Shared;

namespace DependencyInjectionDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBlogService _blogService;

        public HomeController(ILogger<HomeController> logger, IBlogService blogService) // inject interface to the constructor
        {
            _logger = logger;
            _blogService = blogService;
        }

        public IActionResult Index()
        {
           // var blogService = new BlogService();
            var posts = _blogService.GetAllPosts();
            return View(posts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Details(int id)
        {
            //var blogService = new BlogService();
            var post = _blogService.GetPost(id);

            return View(post);
        }
    }
}
