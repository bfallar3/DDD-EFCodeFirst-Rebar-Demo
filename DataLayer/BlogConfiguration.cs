using DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BlogConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Blog>
    {
        public BlogConfiguration ()
        {
            HasKey(k => k.Id);
            Property(p => p.Title).HasMaxLength(255);
            Property(p => p.BloggerName).IsRequired();
            Property(p => p.BloggerName).IsConcurrencyToken();

            MapToStoredProcedures(m => m.Insert(p => p.HasName("sp_InsertBlog")));
            MapToStoredProcedures(m => m.Update(p => p.HasName("sp_UpdateBlog")));
            MapToStoredProcedures(m => m.Delete(p => p.HasName("sp_DeleteBlog")));
        }
    }
}
