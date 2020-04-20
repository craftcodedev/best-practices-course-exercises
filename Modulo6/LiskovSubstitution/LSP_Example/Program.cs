using LSP;
using System;

namespace LSP_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            UserSetting user = new UserSetting();
            user.SetSetting("name", "value");
            user.GetSetting();

            GuestSetting guest = new GuestSetting();
            guest.GetSetting();
        }
    }
}
