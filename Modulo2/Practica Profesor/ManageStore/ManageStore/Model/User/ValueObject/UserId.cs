using System;
using App.Model;
using App.Model.User.ValueObject.Exception;


namespace App.Model.User.ValueObject
{
    public class UserId : App.Model.IntValueObject
    {
        public UserId(int value)
        {
            if (value.Equals(0)) {
                InvalidUserIdException.FromZero();
            }

            this.value = value;
        }
    }
}
