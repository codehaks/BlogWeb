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
            _db.SavingChanges += _db_SavingChanges;
            _db.SavedChanges += _db_SavedChanges;
        }

        private void _db_SavedChanges(object sender, Microsoft.EntityFrameworkCore.SavedChangesEventArgs e)
        {
            Console.WriteLine("Data Saved -------------------");
        }

        private void _db_SavingChanges(object sender, Microsoft.EntityFrameworkCore.SavingChangesEventArgs e)
        {
            Console.WriteLine("Savin Data -------------------");
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

            blog.Name = Blog.Name;
            blog.Description = Blog.Description;

            _db.SaveChanges();

            return RedirectToPage("index");
        }
    }
}
