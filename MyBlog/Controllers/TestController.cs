using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Controllers
{
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly BlogDbContext _db;

        public TestController(BlogDbContext db)
        {
            _db = db;
        }

        [Route("api/one")]
        public IActionResult GetUserProfile()
        {
            var user = _db.User
                .Include(u=>u.Profile)
                .ToList();
            return Ok(user);
        }
        [Route("api/blog")]
        public IActionResult GetBlogs()
        {
            var blogs = _db.Blogs
                .Include(u => u.Posts)
                .ThenInclude(p=>p.Comments)
                .ToList();
            return Ok(blogs);
        }

        [Route("api/post")]
        public IActionResult GetPosts()
        {
            var posts = _db.Posts
                .Include("Blog")
                .Include(p=>p.Comments)
               
                .ToList();
            return Ok(posts);
        }
    }
}
