using System;

namespace Ejemplos
{
    class HighCohesion
    {
        private int _elementA;
        private int _elementB;

        public int MethodA()
        {
            var returnValue = SomeOtherMethod(_elementA);
            return SomeVeryOtherMethod(_elementB);
        }

        public void PrintValues()
        {
            Console.WriteLine(_elementA);
            Console.WriteLine(_elementB);
        }

        private int SomeVeryOtherMethod(int elementB)
        {
            throw new NotImplementedException();
        }

        private object SomeOtherMethod(int elementA)
        {
            throw new NotImplementedException();
        }
    }
}

