using System;

namespace Directos.Module3.Ejercicio5.Utils
{
    public class Teacher
    {
        private int id;
        private string email;

        public Teacher(int id, string email)
        {
            this.id = id;
            this.email = email;
        }

        public string Email()
        {
            return this.email;
        }
    }
}