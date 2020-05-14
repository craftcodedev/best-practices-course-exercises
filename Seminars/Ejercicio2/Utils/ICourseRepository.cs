using System;

namespace Module2.Ejercicio2.Utils
{
    public interface ICourseRepository
    {
        Course FindOneById(string id);
        void Remove(Course course);
    }
}