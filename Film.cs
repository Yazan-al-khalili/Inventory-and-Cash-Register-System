using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4
{
    public class Film : Produkt
    {
        public string Format { get; set; }
        public string Speltid { get; set; }

        public override string Typ => "Film";

        public override string ToCSV()
        {
            // Fill out unused columns with empty commas to reach position 8
            return $"{Typ},{ID},{Namn},{Pris},{Format},{Speltid},,, {LagerAntal}";
        }
    }
}

