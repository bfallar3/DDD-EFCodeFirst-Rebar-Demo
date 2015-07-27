using CodeFirstConvention.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvention
{
    class Program
    {
        static void Main (string[] args)
        {
            var db = new StudentContext();

            // add student
            db.Students.Add(
                new Student { StudentName = "Benjamin P. Fallar III" }
                );

            db.SaveChanges();

            // create blog and posts
            (new List<Blog>() {
                new Blog() { Blogger = "Benjamin", Title="First blog!", 
                    Posts = new List<Post>() {
                        new Post { Content="EF is awesome" },
                        new Post { Content="Angular is great"}
} 
                },
                new Blog() { Blogger = "Rache", Title="Second blog!" }
            }).ForEach(b => db.Blogs.Add(b));

            db.SaveChanges();

            // delete blog, this will also cascade delete to posts.
            var blog = db.Blogs.Find(1);
            db.Blogs.Remove(blog);
            db.SaveChanges();
        }
    }
}
