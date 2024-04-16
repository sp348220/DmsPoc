using System;
//using DocumentManagementSystem.Entities;
using DocumentManagementSystem.API.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
namespace DocumentManagementSystem.API
{
    public class ValueDbContext : DbContext
    {
        public ValueDbContext()
        {

        }
        public ValueDbContext(DbContextOptions<ValueDbContext> options) : base(options)
        {
           // options.UseSqlServer(connection, b => b.MigrationsAssembly("DocumentManagementSystem.API"));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Configure the database connection here
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-4J6IQKA\\\\SQLEXPRESS01;Initial Catalog=DocumentDb;Integrated Security=True;Trust Server Certificate=True;",
                    b => b.MigrationsAssembly("DocumentManagementSystem.API"));
            }
        }


        public virtual DbSet<CustomerModel> Customers { get; set; }
    }
}
