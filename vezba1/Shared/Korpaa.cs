using System;
using System.Collections.Generic;
using System.Text;

namespace vezba1.Shared
{
    public class Korpaa
    {
        public int ID { set; get; }
        public Artikli Korpaica { set; get; }

        public Korpaa() { }

        public Korpaa(Artikli s)
        {
            Korpaica = s;
        }
    }
}
