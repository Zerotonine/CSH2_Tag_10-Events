using System;

namespace CSH2_Tag_10_G62_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Video vid = new Video("Saw 1");
            VideoEncoder enc = new VideoEncoder();
            MailService ms = new MailService();
            PrinterService ps = new PrinterService();
            SMSService smss = new SMSService();

            enc.VideoEncoding += ms.OnVideoEncoded;
            enc.VideoEncoding += ps.OnVideoEncoded;
            enc.VideoEncoding += smss.OnVideoEncoded;

            enc.Encode(vid);

            Console.ReadKey(true);
        }
    }
}
