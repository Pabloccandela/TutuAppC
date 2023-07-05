using AutoMapper;
using TutuApp.ABP.Servicios;

namespace TutuApp.ABP;

public class ABPApplicationAutoMapperProfile : Profile
{
    public ABPApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

         CreateMap<Servicio, ServicioDTO>();
         CreateMap<CreateUpdateServicioDTO, Servicio>();
    }
}
