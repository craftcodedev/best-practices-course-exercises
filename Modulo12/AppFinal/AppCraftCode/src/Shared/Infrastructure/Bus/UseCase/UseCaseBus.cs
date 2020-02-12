using AppCraftCode.src.Shared.Domain.Bus.UseCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppCraftCode.src.Shared.Infrastructure.Bus.UseCase
{
    public class UseCaseBus : IUseCaseBus
    {
        private Dictionary<string, IUseCase> useCases = new Dictionary<string, IUseCase>();

        public UseCaseBus()
        {
            useCases = new Dictionary<string, IUseCase>();
        }

        public void Subscribe(IUseCase useCase)
        {
            string className = useCase.GetType().ToString();
            this.useCases.Add(className, useCase);
        }

        public IResponse Dispatch(IRequest request)
        {
            string className = request.GetType().ToString();
            string[] words = className.Split(new string[] { "Request" }, StringSplitOptions.None);

            string useCaseName = words[0] + "UseCase";

            if (!this.useCases.ContainsKey(useCaseName))
            {
                throw new System.Exception("do not exist the use case " + useCaseName);
            }

            return useCases[useCaseName].Execute(request);
        }
    }
}
