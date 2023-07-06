using System;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using TutuApp.ABP.Servicios;


namespace TutuApp.ABP;

public class BookStoreDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Servicio, Guid> _servicioRepository;

    public BookStoreDataSeederContributor(IRepository<Servicio, Guid> servicioRepository)
    {
        _servicioRepository = servicioRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _servicioRepository.GetCountAsync() <= 0)
        {
            await _servicioRepository.InsertAsync(
                new Servicio
                {
                    Nombre = "Corte a Tijeta",
                    Descripcion="Este es un corte de pelo con tijera",
                    TipoDeServicio =  TipoDeServicio.Estetica,
                    Duracion = 102000,
                    Precio = 1200
                },
                autoSave: true
            );

            await _servicioRepository.InsertAsync(
                new Servicio
                {
                    Nombre = "Consulta medica",
                    Descripcion="Consulta medica unicamente para pacientes",
                    TipoDeServicio =  TipoDeServicio.Salud,
                    Duracion = 560000,
                    Precio = 9000
                },
                autoSave: true
            );

            await _servicioRepository.InsertAsync(
                new Servicio
                {
                    Nombre = "Plan fitness",
                    Descripcion="Entrenamiento con instructor + plan alimenticio",
                    TipoDeServicio =  TipoDeServicio.Salud,
                    Duracion = 100000,
                    Precio = 6800
                },
                autoSave: true
            );
        }
    }
}
