using DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BlogSeedInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            new List<Blog>
            {
                new Blog { Title="Accenture is great", BloggerName="Benjamin" },
                new Blog { Title="Age of Ultron", BloggerName="Benjamin"},
                new Blog { Title="REBAR rocks!", BloggerName="Benjamin"}
            }.ForEach(b => context.Blogs.Add(b));

            base.Seed(context);
        }
    }
}
