using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class MKVVideo : VideoPlayer
    {
        public override void DecodeVideoFormat()
        {
            Console.WriteLine("Decode with MKV format");
        }
    }
}
