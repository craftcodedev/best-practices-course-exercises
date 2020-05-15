using System;
using Module2.Ejercicio2.Utils;

namespace Module2.Ejercicio2
{
    public class DeleteCourseUseCase
    {
        private ICourseRepository courseRepository;
        private DeleteCourseValidator deleteCourseValidator;

        public DeleteCourseUseCase(ICourseRepository courseRepository, DeleteCourseValidator deleteCourseValidator)
        {
            this.courseRepository = courseRepository;
            this.deleteCourseValidator = deleteCourseValidator;
        }

        public void Delete(string courseId)
        {
            Course course = this.courseRepository.FindOneById(courseId);
            
            this.deleteCourseValidator.Validate(course.Id(), course.Status());
            
            this.courseRepository.Remove(course);
        }
    }
}