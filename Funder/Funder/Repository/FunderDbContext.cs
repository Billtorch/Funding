using Funder.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace Funder.Repository
{
    public class FunderDbContext : DbContext
    {
        public DbSet<User> Users{ get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Reward> Rewards { get; set; }
        public DbSet<ProjectCategory> ProjectCategories { get; set; }
        public DbSet<Fund> Funds { get; set; }




        public readonly static string ConnectionString =


       "Server =localhost; " +
       "Database = funder; " +
       "User Id = sa; " +
       "Password = admin!@#123;";

        public FunderDbContext(DbContextOptions<FunderDbContext> options)
                : base(options)
        { 
        
        }
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }


    }
}
