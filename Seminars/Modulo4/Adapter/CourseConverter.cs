using App.Model.Course;
using Ejercicio6.src.Model.Course;
using System;
using System.Collections.Generic;
using System.Text;

namespace Directos.Module4.Adapter
{
    public class CourseConverter
    {
        public CourseDTO Convert(Course course)
        {
            return new CourseDTO(course.Id(), course.Title());
        }

    }
}
