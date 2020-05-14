using System;
using System.Collections.Generic;

namespace Module2.Ejercicio2.Utils
{
    public interface IModuleRepository
    {
        List<Module> FindByCourseId(string courseId);
    }
}