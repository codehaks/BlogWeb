using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string LastName { get; set; }
        public string FirstName { get; set; }

        public byte Age { get; set; }

        public bool IsLocked { get; set; }

        [Column(TypeName = "tinyint")]
        public GenderType Gender { get; set; }

        public RoleType Role { get; set; }

        public DateTime BirthDate { get; set; }
    }

    public enum RoleType:byte
    {
        Member=0,
        Admin=1,
        Customer=2
    }

    public enum GenderType
    {
        None=0,
        Male=1,
        Female=2
    }
}
