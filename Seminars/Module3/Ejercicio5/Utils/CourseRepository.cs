using System;
using System.Collections.Generic;

namespace Directos.Module3.Ejercicio5.Utils
{
    public class CourseRepository
    {
        private IDataMapper<Course> dataMapper;

        public CourseRepository(IDataMapper<Course> dataMapper)
        {
            this.dataMapper = dataMapper;
        }

        public Course FindOneById(string id)
        {
            Dictionary<string, string> criteria = new Dictionary<string,string>();
            criteria.Add("id", id);
            return this.dataMapper.FindOne(criteria);
        }

        public void Remove(Course course)
        {
        }
    }
}