using System.ComponentModel.DataAnnotations;

namespace DomenicaEscobar_ExamenP1.Models
{
    public class DomenicaEscobar_Tabla
    {
        public int Id { get; set; }
        [Required]
        public string? DENombre { get; set; }
        public bool DEPrecio { get; set; }
        [Range(0.01, 9999.99)]
        public decimal DEConTocino { get; set; }
        public DateTime DEFecha { get; set; }
    }
}
