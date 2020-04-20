using System;
using System.Collections.Generic;
using System.Linq;

namespace LSP
{
    class UserSetting : IReadableSetting, IWriteableSetting
    {
        public IReadableSetting GetSetting()
        {
            IReadableSetting setting = null;
            return setting;
        }

        public void SetSetting(string settingName, string settingValue)
        {
            IWriteableSetting newSetting = null;
            // Set settings based on given parameters
        }
    }
}
