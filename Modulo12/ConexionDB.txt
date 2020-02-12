
Install-Package MySql.Data.EntityFrameworkCore

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();

            // define the database to use
            //optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));

            optionsBuilder.UseMySQL(config.GetConnectionString("DefaultConnection"));

        }

  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;database=library;user=user;password=password"
  },