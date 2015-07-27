using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainClasses
{
    public class Blog
    {
        public Blog()
        {
            Posts = new List<Post>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string BloggerName { get; set; }
        public List<Post> Posts { get; set; }
        public string BlogCode
        {
            get
            {
                return Title.Substring(0, 1) + ":" + BloggerName.Substring(0, 1);
            }
        }
    }
}
