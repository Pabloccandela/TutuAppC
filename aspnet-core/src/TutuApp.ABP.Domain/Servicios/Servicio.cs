using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace TutuApp.ABP.Servicios
{
    public class Servicio : AuditedAggregateRoot<Guid>
    {
        public string Nombre { get; set; } = null!;
        public string  Descripcion { get; set; } = null!;
        public double Precio { get; set; }
        public int Duracion { get; set; }
        public TipoDeServicio TipoDeServicio { get; set; }
    }
}