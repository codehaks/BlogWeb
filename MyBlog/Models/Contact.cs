using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class Contact
    {
        public int Id { get; set; }
        
        [Column(name:"Full Name")]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime TimeCreated { get; set; }
    }
}
