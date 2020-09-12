using System;
using BlockbusterApp.src.Shared.Application.Bus.UseCase;
using BlockbusterApp.src.Shared.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using System.Linq;


namespace BlockbusterApp.src.Shared.Infrastructure.Bus.Middleware
{
    
    public class TransactionMiddleware : MiddlewareHandler
    {
        private BlockbusterContext blockbusterContext;

        public TransactionMiddleware(BlockbusterContext blockbusterContext)
        {
            this.blockbusterContext = blockbusterContext;
        }

        public string Name() 
        {
            return this.GetType().Name;
        }

        public override IResponse Handle(IRequest request)
        {
            var transaction = this.blockbusterContext.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

            try
            {
                IResponse response = base.Handle(request);
                this.blockbusterContext.SaveChanges();
                transaction.Commit();
                return response;
            }
            catch (System.Exception e)
            {
                transaction.Rollback();
                this.blockbusterContext.ChangeTracker.Entries().ToList().ForEach(x => x.State = EntityState.Detached);
                throw e;
            }
        }
    }
}
