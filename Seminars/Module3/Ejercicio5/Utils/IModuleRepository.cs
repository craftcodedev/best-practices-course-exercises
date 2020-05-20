using System;
using System.Collections.Generic;

namespace Directos.Module3.Ejercicio5.Utils
{
    public interface IModuleRepository
    {
        List<Module> FindByCourseId(string courseId);
    }
}