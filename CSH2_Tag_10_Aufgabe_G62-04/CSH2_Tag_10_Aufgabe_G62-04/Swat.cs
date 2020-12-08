using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_10_Aufgabe_G62_04
{
    class Swat
    {
        public void Einsatz(object sender, CIA.TextanalyseEventArgs e)
        {
            Console.WriteLine(sender.ToString() + e.Suche + "! GO! GO! GO!");
        }
    }
}
