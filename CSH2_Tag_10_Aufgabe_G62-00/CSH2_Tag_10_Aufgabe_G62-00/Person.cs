using System;
using System.Collections.Generic;
using System.Text;

namespace CSH2_Tag_10_Aufgabe_G62_00
{
    class Person
    {
        public delegate void FeuerEventHandler();
        public event FeuerEventHandler FeuerGerufen;

        public void FeuerRufen()
        {
            Console.WriteLine("Feuer!!!");
            FeuerGerufen?.Invoke();
        }
    }
}
