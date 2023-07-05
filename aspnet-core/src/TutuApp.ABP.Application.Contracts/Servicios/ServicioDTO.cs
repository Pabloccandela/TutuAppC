using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace TutuApp.ABP.Servicios
{
    public class ServicioDTO : AuditedEntityDto<Guid>
    {
        public string Nombre { get; set; } = null!;
        public string  Descripcion { get; set; } = null!;
        public double Precio { get; set; }
        public int Duracion { get; set; }
        public TipoDeServicio TipoDeServicio { get; set; }
    }
}