using AppCraftCode.src.Domain.UserAggregate;
using AppCraftCode.src.Infrastructure.Persistence.Context;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Infrastructure.Persistence.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public UserRepository(UserContext context, IServiceScopeFactory scopeFactory)
            : base(context)
        {
            _scopeFactory = scopeFactory;
        }

        public User FindOneByEmail(UserEmail email)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<UserContext>();
                return dbContext.Customers.FirstOrDefault(c => c.Email.GetValue() == email.GetValue());
            }
        }

        public User FindOneById(UserId id)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<UserContext>();
                return dbContext.Customers.FirstOrDefault(c => c.Id.GetValue() == id.GetValue());
            }
        }

        public void Save(User user)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<UserContext>();
                dbContext.Customers.Add(user);
                dbContext.SaveChanges();
            }
        }
    }
}
