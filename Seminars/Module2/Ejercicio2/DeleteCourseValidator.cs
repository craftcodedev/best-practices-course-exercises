using System;
using Module2.Ejercicio2.Utils;
using System.Collections.Generic;

namespace Module2.Ejercicio2
{
    public class DeleteCourseValidator
    {
        private IModuleRepository moduleRepository;

        public DeleteCourseValidator(IModuleRepository moduleRepository)
        {
            this.moduleRepository = moduleRepository;
        }

        public void Validate(string courseId, string courseStatus)
        {
            this.courseCanBeDeleted(courseId, courseStatus);
        }

        private void courseCanBeDeleted(string courseId, string courseStatus)
        {
            if (courseStatus == "unpublish") {
                throw new System.Exception("Course cannot be delete because his status is unpublish");
            }

            this.ItHasSomeModules(courseId);
        }

        private void ItHasSomeModules(string courseId)
        {
            List<Module> modules = this.moduleRepository.FindByCourseId(courseId);
            
            if (modules.Count > 0) {
                throw new System.Exception("Course cannot be delete because it has some modules");
            }
        }
    }
}
