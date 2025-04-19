using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4
{
    public class Spel : Produkt
    {
        public string Plattform { get; set; }

        public override string Typ => "Spel";

        public override string ToCSV()
        {
            // Fill out unused columns with empty commas to reach position 8
            return $"{Typ},{ID},{Namn},{Pris},{Plattform},,,,{LagerAntal}";
        }
    }
}