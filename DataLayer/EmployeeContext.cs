using DomainClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext ()
        {
            Database.Log = sql => System.Diagnostics.Debug.WriteLine(sql);
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating (DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Manager)
                .WithMany()
                .HasForeignKey(k => k.ManagerID);

            modelBuilder.Entity<Employee>()
                .HasOptional(e => e.Supervisor)
                .WithMany()
                .HasForeignKey(k => k.SupervisorID);

            //modelBuilder.Entity<Employee>()
            //    .Map(m =>
            //    {
            //        m.ToTable("Employee");
            //        m.Properties(p => new { p.EmployeeID, p.Firstname, p.Lastname, p.ManagerID, p.SupervisorID, p.Salary });
            //    })
            //    .Map(m =>
            //    {
            //        m.ToTable("EmployeeAddress");
            //        m.Properties(p => new { p.EmployeeID, p.Address });
            //    });

            //modelBuilder.Entity<Employee>().HasKey(p => p.EmployeeID).ToTable("Employee");
            //modelBuilder.Entity<EmployeeAvatar>().ToTable("Employee");
            //modelBuilder.Entity<Employee>()
            //    .HasRequired(p => p.Avatar)
            //    .WithRequiredPrincipal();

            base.OnModelCreating(modelBuilder);
        }
    }
}
