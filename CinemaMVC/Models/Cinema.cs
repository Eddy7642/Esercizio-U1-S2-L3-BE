using System.Collections.Generic;
using System.Linq;

namespace CinemaMVC.Models
{
    public static class Cinema
    {
        public static List<Ticket> Biglietti { get; set; } = new List<Ticket>();

        public static Dictionary<string, int> CapienzaSale { get; set; } = new Dictionary<string, int>
        {
            { "SALA NORD", 120 },
            { "SALA EST", 120 },
            { "SALA SUD", 120 }
        };

        public static int GetBigliettiVenduti(string sala)
        {
            return Biglietti.Count(t => t.Sala == sala);
        }

        public static int GetBigliettiRidottiVenduti(string sala)
        {
            return Biglietti.Count(t => t.Sala == sala && t.TipoBiglietto == "Ridotto");
        }
    }
}
