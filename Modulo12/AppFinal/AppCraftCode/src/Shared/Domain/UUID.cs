using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AppCraftCode.src.Shared.Domain
{
    public class UUID : StringValueObject
    {
        private const string UUIDV4PATTERN = @"^(\{{0,1}([0-9a-fA-F]){8}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){4}-([0-9a-fA-F]){12}\}{0,1})$";

        public UUID(string value) : base(value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("UUID");
            }

            if (!UUID.Is(value))
            {
                throw new Exception("UUID");
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
