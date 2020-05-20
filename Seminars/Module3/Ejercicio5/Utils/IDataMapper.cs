using System;
using System.Collections.Generic;

namespace Directos.Module3.Ejercicio5.Utils
{
    public interface IDataMapper<T>
    {
        List<T> Find(Dictionary<string, string> criteria, int limit = 1, int offset = 1);
        T FindOne(Dictionary<string, string> criteria);
    }
}