﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IOnlineOrderProcess
    {
        bool ValidateCardInfo(string cardInfo);
    }
}
