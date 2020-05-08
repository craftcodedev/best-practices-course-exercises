using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos
{
    class ClassC
    {
        private bool _elementA;

        public int MethodA()
        {
            if (_elementA)
                return new ClassD()._elementB;

            return 0;
        }

        public void PrintValues()
        {
            new ClassD().MethodB();
        }
    }

    class ClassD
    {
        public int _elementB;

        public void MethodB()
        {
            Console.WriteLine(_elementB);
        }
    }
}
