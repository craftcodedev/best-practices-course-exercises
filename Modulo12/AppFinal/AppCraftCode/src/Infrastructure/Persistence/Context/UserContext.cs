using AppCraftCode.src.Domain.UserAggregate;
using AppCraftCode.src.Infrastructure.Persistence.Mapping;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Infrastructure.Persistence.Context
{
    public class UserContext : DbContext
    {
        private readonly IHostingEnvironment _env;

        public UserContext(IHostingEnvironment env)
        {
            _env = env;
        }

        public DbSet<User> Customers { get; set; }

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
            //optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

            optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password");

        }
    }
}
