namespace AgroStockAI.Models
{
    public class MovimientoInventario
    {
        public int Id { get; set; }

        public int ProductoId { get; set; }

        public Producto? Producto { get; set; }

        public string TipoMovimiento { get; set; } = string.Empty;

        public int Cantidad { get; set; }

        public DateTime Fecha { get; set; }
            = DateTime.Now;
    }
}