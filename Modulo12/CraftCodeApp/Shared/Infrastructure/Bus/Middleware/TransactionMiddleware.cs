using System;
using CraftCodeApp.src.Shared.Application.Bus.UseCase;
using CraftCodeApp.src.Shared.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CraftCodeApp.src.Shared.Infrastructure.Bus.Middleware
{
    public class TransactionMiddleware : MiddlewareHandler
    {
        private CraftCodeContext _craftCodeContext;

        public TransactionMiddleware(CraftCodeContext craftCodeContext)
        {
            _craftCodeContext = craftCodeContext;
        }

        public override IResponse Handle(IRequest request)
        {
            var transaction = _craftCodeContext.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            try
            {
                IResponse response = base.Handle(request);
                _craftCodeContext.SaveChanges();
                transaction.Commit();
                return response;
            }
            catch(System.Exception e)
            {
                transaction.Rollback();
                throw e;
            }

            
        }
    }
}
