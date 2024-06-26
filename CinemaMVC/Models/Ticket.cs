namespace CinemaMVC.Models
{
    public class Ticket
    {

        public string Nome { get; set; } = string.Empty;
        public string Cognome { get; set; } = string.Empty;
        public string Sala { get; set; } = string.Empty;
        public string TipoBiglietto { get; set; } = string.Empty; // "Intero" o "Ridotto"

    }
}
