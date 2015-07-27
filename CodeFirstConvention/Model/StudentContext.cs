using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstConvention.Model
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Blog> Blogs { set; get; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating (DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(k => k.StudentNumber);
            modelBuilder.Entity<Student>().Property(p => p.StudentName).HasMaxLength(100);

            //modelBuilder.Entity<Post>()
            //    .HasRequired(p => p.Blog)
            //    .WithMany(b => b.Posts)
            //    .HasForeignKey(f => f.RandomKey);

            modelBuilder.Entity<Blog>()
                .HasMany(p => p.Posts)
                .WithRequired(p => p.Blog)
                .HasForeignKey(f => f.BlogId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
