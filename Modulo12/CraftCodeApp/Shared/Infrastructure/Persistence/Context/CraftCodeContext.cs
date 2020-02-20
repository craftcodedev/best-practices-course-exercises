using System;
using CraftCodeApp.src.Domain.UserAggregate;
using CraftCodeApp.src.Infrastructure.Persistence.Mapping;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CraftCodeApp.src.Shared.Infrastructure.Persistence.Context
{
    public class CraftCodeContext : DbContext
    {
        private readonly IHostingEnvironment _env;

        public CraftCodeContext(IHostingEnvironment env)
        {
            _env = env;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}