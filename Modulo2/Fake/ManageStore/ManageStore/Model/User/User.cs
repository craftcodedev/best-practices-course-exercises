using App.Model.User.ValueObject;

namespace App.Model.User
{
    public class User : ILoggable
    {
        private UserId id;
        private UserName name;

        private User(UserId id, UserName name)
        {
            this.id = id;
            this.name = name;
        }

        public static User Create(UserId id, UserName name)
        {
            return new User(id, name);
        }

        public UserId Id()
        {
            return this.id;
        }

        public UserName Name()
        {
            return this.name;
        }
    }
}
