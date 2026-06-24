using AgroStockAI.Models;
using System.ComponentModel.DataAnnotations;

namespace AgroStockAI.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}