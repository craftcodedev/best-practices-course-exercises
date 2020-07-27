using System;

namespace Directos.Modulo2.Ejercicio1.Utils
{
    public interface IFileRepository
    {
        File FindOneById(string id);
    }
}
