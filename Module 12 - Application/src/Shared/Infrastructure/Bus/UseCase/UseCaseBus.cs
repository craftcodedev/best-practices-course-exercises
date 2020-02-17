using App.Shared.Domain.Bus.UseCase;
using App.Shared.Domain.Bus.Middleware;
using App.Shared.Infrastructure.Bus.Middleware;
using System.Collections.Generic;
using System;

namespace App.Shared.Infrastructure.Bus.UseCase
{
    public class UseCaseBus : IUseCaseBus
    {
        private Dictionary<string, UseCaseMiddleware> useCases = new Dictionary<string, UseCaseMiddleware>();
        private List<IMiddlewareHandler> middlewareHanders;
        public UseCaseBus()
        {
            this.useCases = new Dictionary<string, UseCaseMiddleware>();
        }

        public void SetMiddlewares(List<IMiddlewareHandler> middlewareHanders)
        {
            this.middlewareHanders = middlewareHanders;
        }
		
        public void Subscribe(IUseCase useCase)
        {
            string className = useCase.GetType().ToString();
            this.useCases.Add(className, new UseCaseMiddleware(useCase));
        }

        public IResponse Dispatch(IRequest request)
        {
            string className = request.GetType().ToString();
            string[] words = className.Split(new string[] { "Request" }, StringSplitOptions.None);

            string useCaseName = words[0] + "UseCase";

            if (!this.useCases.ContainsKey(useCaseName)) {
                throw new System.Exception("do not exist the use case " + useCaseName);
            }
            
            IMiddlewareHandler mHandler = this.useCases[useCaseName];

            foreach (IMiddlewareHandler middlewareHandler in this.middlewareHanders) {
                middlewareHandler.SetNext(mHandler);
                mHandler = middlewareHandler;
            }

            return mHandler.Handle(request);
        }
    }
}