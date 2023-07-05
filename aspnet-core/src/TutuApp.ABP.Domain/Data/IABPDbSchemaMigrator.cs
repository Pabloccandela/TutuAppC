using System.Threading.Tasks;

namespace TutuApp.ABP.Data;

public interface IABPDbSchemaMigrator
{
    Task MigrateAsync();
}
