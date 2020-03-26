using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Student
{
    public static class StudentDataProvider
    {
        public static List<Student> GetData() =>
            new List<Student>
            {
                new Student { City = "Roma", Name = "Jack", Age = 15 },
                new Student { City = "Paris", Name = "Martin", Age = 18 },
                new Student { City = "Barcelona", Name = "George", Age = 21 },
                new Student { City = "Madrid", Name = "John", Age = 16 },
                new Student { City = "NY", Name = "Mery", Age = 20 }
            };
    }
}
