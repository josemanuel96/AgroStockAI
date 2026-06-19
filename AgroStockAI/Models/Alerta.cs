namespace AgroStockAI.Models
{
    public class Alerta
    {
        public int Id { get; set; }

        public string Mensaje { get; set; } = string.Empty;

        public DateTime Fecha { get; set; }
            = DateTime.Now;

        public bool Activa { get; set; }
            = true;
    }
}