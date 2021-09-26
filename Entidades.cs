using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad01
{
    class Entidades
    {
        public class User
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public string Post { get; set; }

            public ICollection<Comments> Comments { get; set; }
        }
        public class Post
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public DateTime Date { get; set; }
            public string Content { get; set; }

            public User User { get; set; }
        }

        public class Comments
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public string Comment { get; set; }

            public User User { get; set; }
        }
    }
}
