using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace TutuApp.ABP.Servicios
{
    public class ServicioAppService
    : CrudAppService<Servicio, ServicioDTO, Guid, PagedAndSortedResultRequestDto, CreateUpdateServicioDTO>, IServicioAppService
    {
        public ServicioAppService(IRepository<Servicio, Guid> repository) : base(repository)
        {
        }
    }
}