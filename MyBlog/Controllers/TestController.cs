using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly BlogDbContext _db;

        public TestController(BlogDbContext db)
        {
            _db = db;
        }

        public IActionResult GetServerTime()
        {
            //var time=_db.Database.ExecuteSqlRaw
            return Ok();
        }
    }
}
