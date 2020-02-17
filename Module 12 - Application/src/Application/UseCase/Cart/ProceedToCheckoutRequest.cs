using System;
using System.Reflection;

namespace App.Application.UseCase
{
    public class ProceedToCheckoutRequest
    {
        public ProceedToCheckoutRequest(
            string id,
            string status
        ) {
            this.Id = id;
            this.Status = status;
        }
        
        public string Id { get; }
        public string Status { get; }
    }
}

