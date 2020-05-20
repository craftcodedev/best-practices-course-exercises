using System.Collections.Generic;

namespace Directos.Module3.Ejercicio1
{
    public interface IUserRepository
    {
        User FindOneById(int id);
    }
}