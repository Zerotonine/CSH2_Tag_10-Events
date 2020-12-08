using System;

namespace CSH2_Tag_10_Aufgabe_G62_00
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Feuerwehrmann f = new Feuerwehrmann();

            p.FeuerGerufen += f.FeuerLöschen;

            p.FeuerRufen();

            Console.ReadKey(true);
        }
    }
}
