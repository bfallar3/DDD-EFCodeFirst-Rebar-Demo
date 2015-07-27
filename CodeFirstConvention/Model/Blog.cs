using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvention.Model
{
    public class Blog
    {
        public Blog ()
        {
            Posts = new List<Post>();
        }
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Blogger { get; set; }

        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int BlogId { get; set; }
        public int PostId { get; set; }
        public string Content { get; set; }        

        // navigation
        public Blog Blog { get; set; }
    }
}
