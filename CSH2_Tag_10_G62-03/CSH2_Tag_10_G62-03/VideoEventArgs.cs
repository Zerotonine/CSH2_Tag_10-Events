using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_10_G62_03
{
    class VideoEventArgs : EventArgs
    {
        public Video Video { get; private set; }
        public DateTime Zeit { get; private set; }
        public VideoEventArgs(Video video)
        {
            this.Video = video;
            this.Zeit = DateTime.Now;
        }
    }
}
