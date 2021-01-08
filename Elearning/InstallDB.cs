
//1. Install mysql package
//Pomelo.EntityFrameworkCore.Mysql  Version 2.1.0

//2. Create dbcontext
using Microsoft.EntityFrameworkCore;

namespace elearning.Shared.Infrastructure.Persistence.Context
{
    public class ELearningContext : DbContext
    {
        public ELearningContext(DbContextOptions opt) : base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

//3. add the following content to startup.json
services.AddDbContextPool<ELearningContext>(options => options
    .UseMySql(Configuration.GetConnectionString("DefaultConnection"))
    .EnableSensitiveDataLogging()
);
services.AddScoped<ELearningContext>();

//4. add the following content to appsettings.json
/**
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;database=elearning;user=root;password=root"
},
**/
