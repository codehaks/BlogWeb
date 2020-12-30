using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.CSharp;
using MyBlog.Data;
using MyBlog.Models;

namespace MyBlog.Pages.Blogs
{
    public class CreateModel : PageModel
    {
        private readonly BlogDbContext _db;

        public CreateModel(BlogDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Blog Blog { get; set; }

        public async Task< IActionResult >OnPost()
        {
            Blog.TimeCreated = DateTime.Now.AddYears(-1);

            var b=await _db.Blogs.AddAsync(Blog);

            var id = b.Entity.Id;

            await _db.SaveChangesAsync();

            var blogId = b.Entity.Id;

            return RedirectToPage("./index");
        }
    }
}
