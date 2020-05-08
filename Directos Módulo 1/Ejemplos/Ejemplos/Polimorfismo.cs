using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplos
{
    //POR HERENCIA
    public class Documento
    {
        public virtual string Convertir()
        {
            return "Convertir documento";
        }
    }

    public class PDF : Documento
    {
        public override string Convertir()
        {
            return base.Convertir();
        }
    }

    public class Excel : Documento
    {
        public override string Convertir()
        {
            return "Otra logica";
        }
    }





    //POR ABSTRACCIÓN
    public abstract class Documento2
    {
        public virtual string Convertir()
        {
            return "Convertir documento";
        }

        public abstract string Leer();
    }

    public class PDF2 : Documento2
    {
        public override string Convertir()
        {
            return base.Convertir();
        }

        public override string Leer()
        {
            return "Leer PDF";
        }
    }

    public class Excel2 : Documento2
    {
        public override string Convertir()
        {
            return "Otra logica";
        }

        public override string Leer()
        {
            return "Leer Excel";
        }
    }






    //POR INTERFACE
    public interface IDocumento
    {
        string Convertir();
        string Leer();
    }

    public class PDF3 : IDocumento
    {
        public string Convertir()
        {
            return "Convertir PDF";
        }

        public string Leer()
        {
            return "Leer PDF";
        }
    }

    public class Excel3 : IDocumento
    {
        public string Convertir()
        {
            return "Convertir Excel";
        }

        public string Leer()
        {
            return "Leer Excel";
        }
    }
}
