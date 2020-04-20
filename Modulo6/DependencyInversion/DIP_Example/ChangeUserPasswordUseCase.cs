using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    class ChangeUserPasswordUseCase
    {
        private INotifier notifier;

        public ChangeUserPasswordUseCase(INotifier notifier)
        {
            this.notifier = notifier;
        }

        public void ChangePassword(string userName, string oldPassword, string newPassword)
        {
            //Lógica cambio password
            notifier.Notify("Password has changed");
        }
    }
}
