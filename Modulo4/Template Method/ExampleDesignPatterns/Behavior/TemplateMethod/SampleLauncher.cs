using System;

namespace TemplateMethod
{
	public class SampleLauncher
	{
		static void Main(string[] args)
		{
            VideoPlayer mkv = new MKVVideo();
            mkv.PlayVideo();

            VideoPlayer mp4 = new MP4Video();
            mp4.PlayVideo();
        }
	}
}
