using System;

namespace CSH2_Tag_10_Aufgabe_G62_04
{
    class Program
    {
        static void Main(string[] args)
        {
            CIA cia = new CIA();
            Swat swat = new Swat();
            FoxNews fox = new FoxNews();

            cia.GefährlichesWortGefunden += swat.Einsatz;
            cia.GefährlichesWortGefunden += fox.Eilmeldung;

            cia.Textanalyse("Wie züchte ich Anthrax?!?!?!?", "anthrax");
            cia.Textanalyse("Wie stelle ich rIzIn her?", "Rizin");

            Console.ReadKey(true);
        }
    }
}
