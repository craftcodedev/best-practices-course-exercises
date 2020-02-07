using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
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
