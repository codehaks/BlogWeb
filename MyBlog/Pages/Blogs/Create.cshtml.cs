using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBlog.Models;

namespace MyBlog.Pages.Blogs
{
    public class CreateModel : PageModel
    {
        public Blog Blog { get; set; }
        public IActionResult OnPost()
        {
            // Save to database
            return Redirect("/index");
        }
    }
}
