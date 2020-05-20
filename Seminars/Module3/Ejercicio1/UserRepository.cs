using System.Collections.Generic;

namespace Directos.Module3.Ejercicio1
{
    public class UserRepository : IUserRepository
    {
        private List<User> users;

        public UserRepository()
        {
            this.users = new List<User>();
            this.users.Add(new User(1, 100));
            this.users.Add(new User(2, 50));
        }

        public User FindOneById(int id)
        {
            foreach (User user in this.users) {
                if (user.Id() == id) {
                    return user;
                }
            }
            
            throw new System.Exception("user not found");
        }
    }
}