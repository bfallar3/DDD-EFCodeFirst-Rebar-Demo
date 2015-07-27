using DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BlogContext : DbContext
    {
        static BlogContext()
        {
            // If using existing database with code-first, you may not want to
            // execute any initialization logic at all. You can disable the
            // database intialization process altogether.
            //Database.SetInitializer<BlogContext>(null);

            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BlogContext>());            
            Database.SetInitializer<BlogContext>(new BlogSeedInitializer());
        }

        public BlogContext() : base("BlogContext")
        {
            // this performs intercepting the generated
            // SQL statement from Entity Framework
            // and write into the Debug window.
            Database.Log = sql => System.Diagnostics.Debug.WriteLine(sql);
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Blog>().MapToStoredProcedures();
            modelBuilder.Configurations.Add(new BlogConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
