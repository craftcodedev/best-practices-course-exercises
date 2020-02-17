using App.Domain.CustomerAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace App.Infrastructure.Persistence.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly IServiceScopeFactory _scopeFactory;

        public CustomerRepository(BlockbusterContext context, IServiceScopeFactory scopeFactory)
            : base(context)
        {
            _scopeFactory = scopeFactory;
        }

        public Customer FindOneByEmail(CustomerEmail email)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<BlockbusterContext>();
                return dbContext.Customers.FirstOrDefault(c => c.Email.GetValue() == email.GetValue());
            }
        }

        public Customer FindOneById(CustomerId id)
        {
            throw new NotImplementedException();
        }

        public void Save(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
