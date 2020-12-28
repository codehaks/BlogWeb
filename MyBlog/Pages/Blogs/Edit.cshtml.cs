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
    public class EditModel : PageModel
    {
        private readonly BlogDbContext _db;

        public EditModel(BlogDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Blog Blog { get; set; }

        public void OnGet(Guid id)
        {
            Blog = _db.Blogs.Find(id);
        }

        public IActionResult OnPost()
        {
            var blog = _db.Blogs.Find(Blog.Id);

            blog.Name = Blog.Name;
            blog.Description = Blog.Description;

            _db.SaveChanges();

            return RedirectToPage("index");
        }
    }
}
