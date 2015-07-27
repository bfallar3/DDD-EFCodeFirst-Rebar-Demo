using DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class SchoolContext : DbContext
    {
        static SchoolContext()
        {
            Database.SetInitializer<SchoolContext>(new DropCreateDatabaseAlways<SchoolContext>());
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // For TPH inheritance, you can change the default 'Discriminator' field
            // behavior by using the fluent API below.

            modelBuilder.Entity<Person>()
                .Map<Person>(m => m.Requires("Type").HasValue("P"))
                .Map<Instructor>(m => m.Requires("Type").HasValue("I"))
                .Map<Student>(m => m.Requires("Type").HasValue("S"));

            base.OnModelCreating(modelBuilder);
        }
    }
}
