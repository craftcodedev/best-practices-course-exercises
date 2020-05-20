using System;

namespace Directos.Module3.Ejercicio5.Utils
{
    public interface ICourseRepository
    {
        Course FindOneById(string id);
        void Remove(Course course);
    }
}