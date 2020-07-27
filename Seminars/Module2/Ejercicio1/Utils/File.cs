using System;

namespace Directos.Modulo2.Ejercicio1.Utils
{
    public class File
    {
        private string id;
        private string name;

        public File(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Id()
        {
            return this.id;
        }

        public string Name()
        {
            return this.name;
        }
    }
}
