using System;

namespace App.Application.UseCase
{
    public class PayOrderRequest
    {
        public PayOrderRequest(
            string id,
            string method,
            string methodInformation
        ) {
            this.Id = id;
            this.Method = method;
            this.MethodData = MethodData;
        }
        
        public string Id { get; }
        public string Method { get; }
        public string MethodData { get; }
    }
}

