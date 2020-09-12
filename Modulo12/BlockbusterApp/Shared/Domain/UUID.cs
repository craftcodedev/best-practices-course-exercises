using System;
using System.Text.RegularExpressions;
using BlockbusterApp.src.Shared.Domain.Exception;

namespace BlockbusterApp.src.Shared.Domain
{
    public class UUID : StringValueObject
    {
        private const string UUIDV4PATTERN = @"^(\{{0,1}([0-9a-fA-F]){8}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){12}\}{0,1})$";

        public UUID(string value) : base(value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw InvalidUUIDException.FromEmpty("UUID");
            }

            if (!UUID.Is(value))
            {
                throw InvalidUUIDException.FromValue("UUID", value);
            }
        }

        public static bool Is(string value)
        {
            Regex regex = new Regex(UUID.UUIDV4PATTERN);
            Match match = regex.Match(value);

            if (match.Success)
            {
                return true;
            }

            return false;
        }
    }
}
