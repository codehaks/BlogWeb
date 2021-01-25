using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private int _Price;

        public int Membership
        {
            get
            {
                return _Price + 20; //$ }
            }
        }

        public int Price
        {
            get { return _Price; }

            set
            {
                if (_Price>1 && _Price<100)
                {
                    _Price = value;
                }
                else
                {
                    new ArgumentOutOfRangeException();
                }
               
            }
        }


        public bool IsDeleted { get; set; }
    }
}
