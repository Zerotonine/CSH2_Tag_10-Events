using System;

namespace CSH2_Tag_10_G62_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Einkaufszentrum ekz = new Einkaufszentrum();
            Geschaeftsfuehrer gf = new Geschaeftsfuehrer();
            Mitarbeiter ma = new Mitarbeiter();

            ekz.NeuerKundeHatDasGebäudeBetreten += gf.Grüßen;
            ekz.NeuerKundeHatDasGebäudeBetreten += ma.Grüßen;

            ekz.KundeBetrittDasGebäude();

            Console.ReadKey(true);
        }
    }
}
