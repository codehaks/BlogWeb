using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class Blog:ITimeCreated,ITimeModified
    {
        
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime TimeCreated { get; set; }

        public DateTime? TimeModfied { get; set; }

    }

    internal interface ITimeModified
    {
        DateTime? TimeModfied { get; set; }
    }

    public interface ITimeCreated
    {
        DateTime TimeCreated { get; set; }
    }
}
