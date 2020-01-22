using System;

namespace ValidatorWithMoq.Tests
{
    //Hacer esta clase testeable. Añadir más lógica si lo creéis conveniente.
    //Crear los tests unitarios con Moq

    public class MyClass
    {
        public bool MyMethod()
        {
            var smtpSender = new SmtpSender();
            smtpSender.SendSmtp("message");
            return true;
        }
    }

    public class SmtpSender
    {
        public void SendSmtp(string message)
        {
            Console.WriteLine(message);
        }
    }
}
