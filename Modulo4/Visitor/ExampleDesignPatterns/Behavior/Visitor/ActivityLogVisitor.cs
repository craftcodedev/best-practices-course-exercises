using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ActivityLogVisitor : IVisitor
    {
        public void Visit(Course course)
        {
            Logger.Log("Course.txt", "El curso " + course.Name + " ha sido finalizado " + course.Date);
        }

        public void Visit(Class classCourse)
        {
            Logger.Log("Class.txt", "La clase " + classCourse.Name + " ha sido visto por " + classCourse.StudentName);
        }

        public void Visit(Practice practice)
        {
            Logger.Log("Practice.txt", "La práctica " + practice.Name + " ha sido terminada por " + practice.StudentName);
        }
    }
}
