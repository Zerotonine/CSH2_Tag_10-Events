using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_10_G62_03
{
    class SMSService : IOnVideoEncoded
    {
        public void OnVideoEncoded(object sender, VideoEventArgs e)
        {
            Console.WriteLine("Verschicke SMS...");
            Console.WriteLine("Sender:\t\t" + sender.ToString());
            Console.WriteLine("EArgs Video:\t" + e.Video.Name);
            Console.WriteLine("EArgs Zeit:\t" + e.Zeit.ToShortTimeString());
            Console.WriteLine();
        }
    }
}
