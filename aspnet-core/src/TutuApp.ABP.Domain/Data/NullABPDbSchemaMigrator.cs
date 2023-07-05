using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TutuApp.ABP.Data;

/* This is used if database provider does't define
 * IABPDbSchemaMigrator implementation.
 */
public class NullABPDbSchemaMigrator : IABPDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
