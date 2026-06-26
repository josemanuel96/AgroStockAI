using AgroStockAI.Models;

namespace AgroStockAI.ViewModels
{
    public class DashboardViewModel
    {
        public int TotalProductos { get; set; }
        public int TotalCategorias { get; set; }
        public int TotalMovimientos { get; set; }
        public int TotalAlertasActivas { get; set; }

        public List<MovimientoInventario> UltimosMovimientos { get; set; } = new();
    }
}