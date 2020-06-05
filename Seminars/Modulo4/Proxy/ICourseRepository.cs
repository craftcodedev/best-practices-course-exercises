using System;
using System.Collections.Generic;

namespace Directos.Module4.Proxy
{
    public interface ICourseRepository
    {
        Course FindById(int id);
        void Save(Course course);
        void Update(Course course);
        List<Course> GetAll();
    }
}