using CodeFirstManyToManyBridgeTableDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstManyToManyBridgeTableDemo
{
    class Program
    {
        static void Main (string[] args)
        {
            var db = new StudentContext();

            // add students
            new List<Student>() {
                new Student { StudentName = "Benjamin" },
                new Student { StudentName = "Rache" },
                new Student { StudentName = "Eric" }
            }.ForEach(s => db.Students.Add(s));

            // add courses
            new List<Course>() {
                new Course { CourseName = "ASP.NET MVC" },
                new Course { CourseName = "AngularJS" },
                new Course { CourseName = "EntityFramework Code First" }
            }.ForEach(s => db.Courses.Add(s));

            // add students to courses
            new List<StudentCourses>()
            {
                new StudentCourses { StudentID = 1, CourseID = 1, EnrolledOn = DateTime.Now },
                new StudentCourses { StudentID = 1, CourseID = 2, EnrolledOn = DateTime.Now },
                new StudentCourses { StudentID = 1, CourseID = 3, EnrolledOn = DateTime.Now },
                new StudentCourses { StudentID = 2, CourseID = 1, EnrolledOn = DateTime.Now },
                new StudentCourses { StudentID = 2, CourseID = 2, EnrolledOn = DateTime.Now },
                new StudentCourses { StudentID = 3, CourseID = 3, EnrolledOn = DateTime.Now }
            }.ForEach(s => db.StudentCourses.Add(s));

            db.SaveChanges();

            var query = (from studentCourse in db.StudentCourses
                         select new
                         {
                             StudentName = studentCourse.Student.StudentName,
                             CourseName = studentCourse.Course.CourseName,
                             EnrolledOn = studentCourse.EnrolledOn
                         }).ToList();

            foreach(var item in query)
            {
                Console.WriteLine("{0} is attending {1} on {2}", item.StudentName, item.CourseName, item.EnrolledOn);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
