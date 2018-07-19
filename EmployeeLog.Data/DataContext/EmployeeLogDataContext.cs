using EmployeeLog.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLog.Data.DataContext
{
    public class EmployeeLogDataContext : DbContext
    {
        public EmployeeLogDataContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=DESKTOP-86VG5BM;Database=EmployeeLog;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkItemDetail>().HasKey(x => new { x.WorkItemID, x.WorkDate }); 
        }


        public DbSet<Employee> Employees { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<WorkItem> WorkItem { get; set; }

        public DbSet<WorkItemDetail> WorkItemDetails { get; set; }

        public DbSet<WorkItemStatus> WorkItemStatus { get; set; }
    }
}
