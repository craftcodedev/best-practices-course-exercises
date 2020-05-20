using System;
using System.Collections.Generic; 

namespace Directos.Module3.Ejercicio5.Utils
{
    public interface IMailer
    {
        void Send(string from, string to, string subject, string body);
    }
}