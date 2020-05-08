using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos
{
    class ClassA
    {
        private readonly ISomeInterface _interfaceImpl;

        public ClassA(ISomeInterface interfaceImpl)
        {
            _interfaceImpl = interfaceImpl;
        }

        public int MethodA()
        {
            return _interfaceImpl.MethodB();
        }

        public void PrintValues()
        {
            _interfaceImpl.PrintValues();
        }
    }

    interface ISomeInterface
    {
        int MethodB();
        void PrintValues();
    }

    class ClassB : ISomeInterface
    {
        private int _elementB = 2 + 2;

        public int MethodB()
        {
            return _elementB;
        }

        public void PrintValues()
        {
            Console.WriteLine(_elementB);
        }
    }
}
