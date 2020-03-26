using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        private static Logger instance = null;

        private Logger()
        {

        }

        public static Logger GetInstance()
        {
            if(instance == null)
            {
                Logger logger = new Logger();
                return logger;
            }

            return instance;
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
