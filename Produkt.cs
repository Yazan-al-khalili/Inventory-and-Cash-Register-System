using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Laboration4
    {
        public class Produkt
        {
            public string ID { get; set; }
            public string Namn { get; set; }
            public decimal Pris { get; set; }

        public int LagerAntal { get; set; } = 0;

        public virtual string Typ => "Produkt";

            // Optional: For saving to CSV later
            public virtual string ToCSV()
            {
                return $"{Typ},{ID},{Namn},{Pris},{LagerAntal}";
            }
        }
    }



