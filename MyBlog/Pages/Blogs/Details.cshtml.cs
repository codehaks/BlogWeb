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
    public class DetailsModel : PageModel
    {
        private readonly BlogDbContext _db;

        public DetailsModel(BlogDbContext db)
        {
            _db = db;
            Blog = new();

        }

        public Blog? Blog { get; set; }
        public void OnGet(string id)
        {
            Blog=_db.Blogs.FirstOrDefault(b=>b.Id==Guid.Parse(id));
            
        }
    }
}
