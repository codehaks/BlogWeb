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
    public class IndexModel : PageModel
    {
        public List<Blog> Blogs { get; set; }
        public void OnGet([FromServices] BlogDbContext db)
        {
            Blogs = db.Blogs.ToList();
        }
    }
}
