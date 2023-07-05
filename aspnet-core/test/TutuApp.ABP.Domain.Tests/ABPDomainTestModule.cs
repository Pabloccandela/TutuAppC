using TutuApp.ABP.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TutuApp.ABP;

[DependsOn(
    typeof(ABPEntityFrameworkCoreTestModule)
    )]
public class ABPDomainTestModule : AbpModule
{

}
