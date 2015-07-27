using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConcurrencyDemo
{
    class Program
    {
        static void Main (string[] args)
        {
            var db = new PeopleContext();
            
            //add new person
            db.PeopleSet.Add(new People { Name = "Benjamin" });
            db.SaveChanges();

            //modify
            var person = db.PeopleSet.Find(1);
            person.Name = "Eric";
            db.Entry(person).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
