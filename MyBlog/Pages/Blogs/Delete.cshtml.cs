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
    public class DeleteModel : PageModel
    {
        private readonly BlogDbContext _db;

        public DeleteModel(BlogDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Blog Blog { get; set; }

        public void OnGet(int id)
        {
            Blog = _db.Blogs.Find(id);
        }

        public IActionResult OnPost()
        {
            var blog = _db.Blogs.Find(Blog.Id);
            blog.IsDeleted = true;
            //_db.Blogs.Remove(blog);

            _db.SaveChanges();

            return RedirectToPage("index");
        }
    }
}
