using CodeFirstManyToManyDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstManyToManyDemo
{
    class Program
    {
        static void Main (string[] args)
        {
            var db = new StudentContext();

            var query = db.Students.Include("Courses").ToList();
        }
    }
}
