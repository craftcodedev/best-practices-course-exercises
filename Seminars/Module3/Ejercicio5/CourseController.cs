using System;
using System.Collections.Generic;
using Directos.Module3.Ejercicio5.Utils;

namespace Directos.Module3.Ejercicio5
{
    public class CourseController
    {
        private ICourseRepository courseRepository;
        private IModuleRepository moduleRepository;
        private IMailer mailer;
        
        public CourseController(ICourseRepository courseRepository, IModuleRepository moduleRepository, IMailer mailer)
        {
            this.courseRepository = courseRepository;
            this.moduleRepository = moduleRepository;
            this.mailer = mailer;
        }

        public void Delete(string courseId)
        {
            Course course = this.getCourse(courseId);
            string id = course.Id();

            if (course.Status() == "publish") {
                List<Module> modules = this.getModulesFromCourseId(courseId);
                
                if (modules.Count > 0) {
                    throw new System.Exception("course cannot be delete because contents modules");
                } else {
                    this.courseRepository.Remove(course);
                    List <Teacher> teachers = course.Teachers();

                    foreach(Teacher teacher in teachers) {
                        this.mailer.Send("hello@craft-code.com", teacher.Email(), "Course Deleted", "Course has been deleted");
                    }
                }
            } else {
                throw new System.Exception("course cannot be delete because of its status");
            }
        }

        private Course getCourse(string courseId)
        {
            return this.courseRepository.FindOneById(courseId);
        }

        private List<Module> getModulesFromCourseId(string courseId)
        {
            return this.moduleRepository.FindByCourseId(courseId);
        }
    }
}
