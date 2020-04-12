using System;
using System.Collections.Generic;
using System.Text;

namespace vezba1.Shared
{
    public class Artikli
    {
        public int ID { set; get; }
        public string Ime{ set; get; }
        public string Cena { set; get; }
        public int Kolicina { set; get; }

        public Artikli() { }

        public Artikli(string i, string c, int k)
        {
            Ime = i;
            Cena = c;
            Kolicina = k;
        }
        public override string ToString()
        {
            return $"{Ime}";
        }

    }
}
