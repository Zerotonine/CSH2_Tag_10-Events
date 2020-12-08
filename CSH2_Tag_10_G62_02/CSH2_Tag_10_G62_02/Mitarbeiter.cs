using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_10_G62_02
{
    class Mitarbeiter : IMitarbeiterBegrüssenKunde
    {
        public void Grüßen()
        {
            Console.WriteLine("MA:\tIrasshaimase!");
        }
    }
}
