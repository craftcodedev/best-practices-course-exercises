using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplos
{
    public abstract class Calc<T>
    {
        public abstract T Add(T x, T y);
        public abstract T Sub(T x, T y);
    }

    public class MiClase : Calc<int>
    {
        public override int Add(int x, int y)
        {
            return x + y;
        }
        public override int Sub(int x, int y)
        {
            return x - y;
        }
    }




    public class MetodoGenerico
    {
        public static void MiMetodoGenerico<T>(T t)
        {
            Console.WriteLine(t);
        }
    }




    public class ComplexBox<T, Content1, Content2>
    {
        public Content1 C1 { get; set; }
        public Content2 C2 { get; set; }
        public T Item { get; set; }

        public ComplexBox(Content1 c1, Content2 c2)
        {
            C1 = c1;
            C2 = c2;
        }
    }

    // ...

    //var caja = new ComplexBox<double, decimal, float>(1, 2)
    //{
    //    Item = 3
    //};








    public class OperationResult
    {
        public bool Success => !MessageList.Any();
        public List<string> MessageList { get; private set; }
        public Persona Persona { get; set; }

        public OperationResult()
        {
            MessageList = new List<string>();
        }

        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }

        public void SetSuccesResponse(Persona pers)
        {
            Persona = pers;
        }
    }

    public class Persona
    {
    }

    public class OperationResultCars
    {
        public bool Success => !MessageList.Any();
        public List<string> MessageList { get; private set; }
        public Car Coche { get; set; }

        public OperationResultCars()
        {
            MessageList = new List<string>();
        }

        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }

        public void SetSuccesResponse(Car coche)
        {
            Coche = coche;
        }
    }

    public class Car
    {
    }

    public class OperationResult<T>
    {
        public bool Success => !MessageList.Any();
        public List<string> MessageList { get; private set; }
        public T Response { get; set; }

        public OperationResult()
        {
            MessageList = new List<string>();
        }

        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }

        public void SetSuccesResponse(T obj)
        {
            Response = obj;
        }
    }
}
