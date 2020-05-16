using System;

namespace Visitor
{
	public class SampleLauncher
	{
		static void Main(string[] args)
		{
            var course = new Course
            {
                Id = 1,
                Name = "Course 1",
                Date = DateTime.Now
            };

            var classCourse = new Class
            {
                Id = 1,
                Name = "Class 2",
                StudentName = "Student 1"
            };

            var practice = new Practice
            {
                Id = 1,
                Name = "Practice 3",
                StudentName = "Student 2"
            };

            //No visitor
            if(course is Course)
            {
                Logger.Log("Course.txt", "El curso " + course.Name + " ha sido finalizado " + course.Date);
            }
            else if(classCourse is Class)
            {
                Logger.Log("Class.txt", "La clase " + classCourse.Name + " ha sido visto por " + classCourse.StudentName);
            }
            else if (practice is Practice)
            {
                Logger.Log("Practice.txt", "La práctica " + practice.Name + " ha sido terminada por " + practice.StudentName);
            }

            //Visitor
            ActivityLogVisitor activity = new ActivityLogVisitor();
            //activity.Visit(course);
            //activity.Visit(practice);
            //activity.Visit(classCourse);

            //#BAD.....................................


            //No visitor
            if(object is Course)
            {
                Logger.Log("Course.txt", "El curso " + course.Name + " ha sido finalizado " + course.Date);
            }
            else if(object is Class)
            {
                Logger.Log("Class.txt", "La clase " + classCourse.Name + " ha sido visto por " + classCourse.StudentName);
            }
            else if (object is Practice)
            {
                Logger.Log("Practice.txt", "La práctica " + practice.Name + " ha sido terminada por " + practice.StudentName);
            }

            //object can be course, class, practica
            object.Accept(new ActivityLogVisitor());
        }
	}
}
