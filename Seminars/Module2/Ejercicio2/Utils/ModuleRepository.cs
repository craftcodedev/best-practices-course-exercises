using System;
using System.Collections.Generic;

namespace Module2.Ejercicio2.Utils
{
    public class ModuleRepository
    {
        private IDataMapper<Module> dataMapper;

        public ModuleRepository(IDataMapper<Module> dataMapper)
        {
            this.dataMapper = dataMapper;
        }

        public List<Module> FindByCourseId(string courseId)
        {
            Dictionary<string, string> criteria = new Dictionary<string,string>();
            criteria.Add("courseId", courseId);
            
            return this.dataMapper.Find(criteria);
        }
    }
}