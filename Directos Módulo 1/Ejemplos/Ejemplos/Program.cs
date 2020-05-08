using System;

namespace Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            string b = "Esto es una prueba";

            MetodoGenerico.MiMetodoGenerico<int>(a);
            MetodoGenerico.MiMetodoGenerico<string>(b);




            PDF pdf1 = new PDF();
            PDF pdf2 = new PDF();
            Excel excel1 = new Excel();
            Excel excel2 = new Excel();

            Documento[] documentos = { pdf1, pdf2, excel1, excel2 };

            foreach (var item in documentos)
            {
                Console.WriteLine(item.Convertir());
                //Console.WriteLine(item.Leer());
            }
        }
    }
}
