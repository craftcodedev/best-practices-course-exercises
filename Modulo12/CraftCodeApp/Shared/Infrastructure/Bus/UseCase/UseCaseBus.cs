using System;
using System.Collections.Generic;
using CraftCodeApp.src.Shared.Application.Bus.UseCase;
using CraftCodeApp.src.Shared.Infrastructure.Bus.Middleware;

namespace CraftCodeApp.src.Shared.Infrastructure.Bus.UseCase
{
    public class UseCaseBus : IUseCaseBus
    {
        private Dictionary<string, UseCaseMiddleware> useCases;
        private List<IMiddlewareHandler> middlewareHanders;

        public UseCaseBus()
        {
            useCases = new Dictionary<string, UseCaseMiddleware>();
        }

        public void SetMiddlewares(List<IMiddlewareHandler> middlewareHanders)
        {
            this.middlewareHanders = middlewareHanders;
        }

        public void Subscribe(IUseCase useCase)
        {
            string className = useCase.GetType().ToString();
            useCases.Add(className, new UseCaseMiddleware(useCase));
        }

        public IResponse Dispatch(IRequest req)
        {
            string className = req.GetType().ToString();
            string[] words = className.Split(new string[] { "Request" }, StringSplitOptions.None);

            string useCaseName = words[0] + "UseCase";

            if(!useCases.ContainsKey(useCaseName))
            {
                throw new Exception("Not exists the usecase " + useCaseName);
            }

            IMiddlewareHandler mHandler = this.useCases[useCaseName];

            foreach (IMiddlewareHandler middlewareHandler in this.middlewareHanders)
            {
                middlewareHandler.SetNext(mHandler);
                mHandler = middlewareHandler;
            }

            return mHandler.Handle(req);
        }
    }
}
