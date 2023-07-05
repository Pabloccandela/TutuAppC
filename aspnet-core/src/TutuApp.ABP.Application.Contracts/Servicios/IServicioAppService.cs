using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace TutuApp.ABP.Servicios
{
    public interface IServicioAppService : 
    ICrudAppService <ServicioDTO, Guid, PagedAndSortedResultRequestDto,CreateUpdateServicioDTO>
    {
        
    }
}