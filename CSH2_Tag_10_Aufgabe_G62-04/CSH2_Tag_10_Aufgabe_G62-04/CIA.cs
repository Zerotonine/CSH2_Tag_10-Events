using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_10_Aufgabe_G62_04
{
    class CIA
    {
        public class TextanalyseEventArgs :EventArgs
        {
            public string Suche { get; set; }
            public TextanalyseEventArgs(string suche)
            {
                this.Suche = suche;
            }
        }

        public event EventHandler<TextanalyseEventArgs> GefährlichesWortGefunden;

        public void Textanalyse(string text, string suche)
        {
            if (text.Contains(suche, StringComparison.InvariantCultureIgnoreCase))
                GefährlichesWortGefunden?.Invoke(this, new TextanalyseEventArgs(suche));
        }

        public override string ToString()
        {
            return "CIA meldet: ";
        }
    }
}
