using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_10_Aufgabe_G62_04
{
    class FoxNews
    {
        public void Eilmeldung(object sender, CIA.TextanalyseEventArgs e)
        {
            Console.WriteLine(sender.ToString() + "Eilmeldung: " + e.Suche);
        }
    }
}
