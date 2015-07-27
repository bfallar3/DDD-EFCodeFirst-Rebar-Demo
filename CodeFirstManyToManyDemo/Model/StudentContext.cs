using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstManyToManyDemo.Model
{
    public class StudentContext : DbContext
    {
        public StudentContext () : base("StudentContext")
        {
            Database.Log = sql => System.Diagnostics.Debug.WriteLine(sql);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating (DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(c => c.Courses)
                .WithMany(s => s.Students)
                .Map(m =>
                    {
                        m.ToTable("StudentCourses");
                        m.MapLeftKey("StudentID");
                        m.MapRightKey("CourseID");
                    }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}
