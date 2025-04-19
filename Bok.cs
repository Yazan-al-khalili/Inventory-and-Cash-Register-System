using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4
{
    public class Bok : Produkt
    {
        public string Författare { get; set; }
        public string Genre { get; set; }
        public string Format { get; set; }
        public string Språk { get; set; }

        public override string Typ => "Bok";

        public override string ToCSV()
        {
            return $"{Typ},{ID},{Namn},{Pris},{Författare},{Genre},{Format},{Språk},{LagerAntal}";
        }
    }
}

