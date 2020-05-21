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
        public DbSet<ProjectCategories> ProjectCategories { get; set; }




        private readonly string connectionString =


       "Server =localhost; " +
       "Database = Funder; " +
       "User Id = sa; " +
       "Password = admin!@#123;";

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }


    }
}
