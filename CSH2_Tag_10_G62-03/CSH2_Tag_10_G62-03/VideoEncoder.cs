using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSH2_Tag_10_G62_03
{
    class VideoEncoder
    {
        public event EventHandler<VideoEventArgs> VideoEncoding;
        public void Encode(Video video)
        {
            Console.WriteLine("Starte Encoding für {" + video.Name + "...");
            for (int i = 0; i < 500; i += 100)
            {
                Thread.Sleep(i);
                Console.WriteLine(".");
            }
            
            Console.WriteLine("Encoding abgeschlossen!\n");
            VideoEncoding?.Invoke(this, new VideoEventArgs(video));
        }

        public override string ToString()
        {
            return "Sender == VideoEncoder";
        }
    }
}
