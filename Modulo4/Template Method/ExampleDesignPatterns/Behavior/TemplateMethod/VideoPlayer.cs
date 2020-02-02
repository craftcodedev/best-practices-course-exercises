using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class VideoPlayer
    {
        public void LoadFile()
        {
            Console.WriteLine("Load file");
        }

        public abstract void DecodeVideoFormat();

        public void StartVideo()
        {
            Console.WriteLine("Start video");
        }

        public void PlayVideo()
        {
            LoadFile();
            DecodeVideoFormat();
            StartVideo();
        }
    }
}
