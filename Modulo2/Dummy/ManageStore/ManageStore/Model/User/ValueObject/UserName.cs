using System;
using App.Model.User.ValueObject.Exception;

namespace App.Model.User.ValueObject
{
    public class UserName : App.Model.StringValueObject
    {
        public const int MAX_SIZE = 15;

        public UserName(string value)
        {
            if (value.Length == 0) {
                InvalidUserNameException.FromEmpty();
            }

            if (value.Length > UserName.MAX_SIZE) {
                InvalidUserNameException.FromMaxLength();
            }

            this.value = value;
        }
    }
}
