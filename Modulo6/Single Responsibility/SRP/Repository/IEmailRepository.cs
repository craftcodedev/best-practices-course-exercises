using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Repository
{
    public interface IEmailRepository
    {
        void Send(EmailInfo emailInfo);
    }
}
