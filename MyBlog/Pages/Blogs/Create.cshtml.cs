using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public IActionResult OnPost()
        {
            _db.Blogs.Add(Blog);
            _db.SaveChanges();

            return Redirect("/index");
        }
    }
}
