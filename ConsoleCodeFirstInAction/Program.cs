using DataLayer;
using DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirstInAction
{
    class Program
    {
        static void Main (string[] args)
        {
            // 01 Code first first demo.
            //CreateBlog();
            //AddPost();

            // 02 Demo for Table per type inheritance in Entity Framework.
            CreateInstructor();
            CreateStudent();

            // 03 Demo for self-referencing association in code-first.
            //CreateEmployee();

            // 04 Demo for many-to-many relationship in code-first.

            // 05 Demo code first stored procedures.
            //CreateBlogWithStoredProcedure();
        }

        static void CreateBlog ()
        {
            using (var context = new BlogContext())
            {
                var blog = new Blog()
                {
                    BloggerName = "Benjamin",
                    Title = "Accenture is awesome"
                };

                context.Blogs.Add(blog);
                context.SaveChanges();
            }
        }

        static void AddPost ()
        {
            using (var context = new BlogContext())
            {
                var blog = context.Blogs.Find(1);

                var post = new Post
                {
                    Content = "I worked in Accenture Cybergate Tower 3!",
                    Title = "My First Post"
                };

                blog.Posts.Add(post);
                context.SaveChanges();
            }
        }

        static void CreateStudent ()
        {
            var db = new SchoolContext();

            var student = new Student()
            {
                Firstname = "Rache",
                Lastname = "Asto",
                EnrollmentDate = DateTime.Now
            };

            db.People.Add(student);
            db.SaveChanges();
        }

        static void CreateInstructor ()
        {
            var db = new SchoolContext();

            var instructor = new Instructor()
            {
                Firstname = "Benjamin",
                Lastname = "Fallar III",
                HireDate = DateTime.Now
            };

            db.People.Add(instructor);
            db.SaveChanges();
        }

        static void CreateEmployee ()
        {
            // always drop and create the SchoolContext database.
            Database.SetInitializer<EmployeeContext>(new DropCreateDatabaseAlways<EmployeeContext>());

            var db = new EmployeeContext();

            new List<Employee>()
            {
                new Employee() { Firstname = "Benjamin", Lastname="Fallar", Salary=10000 },
                new Employee() { Firstname="Manny", Lastname="Pacquiao", Salary=10000, ManagerID=1 },
                new Employee() { Firstname="Floyd", Lastname="Mayweather", Salary=10000, ManagerID=1, SupervisorID=2 }

            }.ForEach(e => db.Employees.Add(e));

            db.SaveChanges();

            // display employees
            var employees = db.Employees.ToList();
            Console.WriteLine("Employee status");
            foreach (var emp in employees)
            {
                Console.WriteLine("{0} is managed by {1} and supervised by {2}",
                    emp.Firstname + " " + emp.Lastname,
                    emp.Manager != null ? emp.Manager.Firstname + " " + emp.Manager.Lastname : "none",
                    emp.Supervisor != null ? emp.Supervisor.Firstname + " " + emp.Supervisor.Lastname : "none");
            }
        }

        static void CreateBlogWithStoredProcedure ()
        {
            var db = new BlogContext();

            // add
            db.Blogs.Add(new Blog { Title = "First blog", BloggerName = "Benjamin" });
            db.Blogs.Add(new Blog { Title = "Second blog", BloggerName = "Rache" });
            db.SaveChanges();

            // update
            var blogToUpdate = db.Blogs.FirstOrDefault(e => e.BloggerName == "Benjamin");
            blogToUpdate.BloggerName = "Benj";
            db.Entry(blogToUpdate).State = EntityState.Modified;
            db.SaveChanges();

            // delete
            var blogToDelete = db.Blogs.FirstOrDefault(e => e.BloggerName == "Rache");
            db.Blogs.Remove(blogToDelete);
            db.SaveChanges();

            // select
            var blogs = db.Blogs.ToList();
            foreach (var b in blogs)
            {
                Console.WriteLine("{0} blogged by {1} at {2}", b.Title, b.BloggerName, DateTime.Now.ToString());
            }

            db.Dispose();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
