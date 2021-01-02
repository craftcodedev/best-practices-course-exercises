
//1. Install mysql package
//Pomelo.EntityFrameworkCore.Mysql  Version 2.1.0

//2. add the following content to startup.json
services.AddDbContextPool<ELearningContext>(options => options
    .UseMySql(this.configuration.GetConnectionString("DefaultConnection"))
    .EnableSensitiveDataLogging()
);
services.AddScoped<ELearningContext>();

//3. create dbcontext
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
