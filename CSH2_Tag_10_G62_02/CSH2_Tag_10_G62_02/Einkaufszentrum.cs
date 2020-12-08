using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_10_G62_02
{
    class Einkaufszentrum
    {
        public delegate void NeuerKundeEventHandler();
        public event NeuerKundeEventHandler NeuerKundeHatDasGebäudeBetreten;

        public void KundeBetrittDasGebäude()
        {
            NeuerKundeHatDasGebäudeBetreten?.Invoke();
        }
    }
}
