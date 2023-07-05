using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TutuApp.ABP.Servicios
{
    public class CreateUpdateServicioDTO
    {
        [Required]
        public string Nombre { get; set; } = null!;
        [Required]
        public string  Descripcion { get; set; } = null!;
        [Required]
        public double Precio { get; set; }
        [Required]
        public int Duracion { get; set; }
        [Required]
        public TipoDeServicio TipoDeServicio { get; set; } = TipoDeServicio.Indefinido;
    }
}