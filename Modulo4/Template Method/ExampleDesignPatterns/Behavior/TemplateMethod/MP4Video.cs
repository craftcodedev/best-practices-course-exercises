using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class MP4Video : VideoPlayer
    {
        public override void DecodeVideoFormat()
        {
            Console.WriteLine("Decode with MP4 format");
        }
    }
}
