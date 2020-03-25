
//1. Install mysql package
//Pomelo.EntityFrameworkCore.Mysql  Version 2.1.0

//2. add the following content to startup.json
services.AddDbContextPool<BlockbusterContext>(options => options
    .UseMySql(Configuration.GetConnectionString("DefaultConnection"))
);
