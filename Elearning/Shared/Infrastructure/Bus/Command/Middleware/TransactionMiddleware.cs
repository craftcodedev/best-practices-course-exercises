using System;
using elearning.Shared.Domain.Bus.Command;
using elearning.Shared.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace elearning.Shared.Infrastructure.Bus.Command.Middleware
{
    public class TransactionMiddleware : MiddlewareHandler
    {
        private readonly ELearningContext ELearningContext;

        public TransactionMiddleware(ELearningContext eLearningContext)
        {
            ELearningContext = eLearningContext;
        }

        public override void Handle(ICommand command)
        {
            using (var transaction = ELearningContext.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                try
                {
                    base.Handle(command);
                    ELearningContext.SaveChanges();
                    transaction.Commit();
                }
                catch (System.Exception e)
                {
                    transaction.Rollback();
                    throw e;
                }
            }
        }
    }
}