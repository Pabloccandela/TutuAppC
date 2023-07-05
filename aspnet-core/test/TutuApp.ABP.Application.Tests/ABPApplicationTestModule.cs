using Volo.Abp.Modularity;

namespace TutuApp.ABP;

[DependsOn(
    typeof(ABPApplicationModule),
    typeof(ABPDomainTestModule)
    )]
public class ABPApplicationTestModule : AbpModule
{

}
