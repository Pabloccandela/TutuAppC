using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TutuApp.ABP;

[Dependency(ReplaceServices = true)]
public class ABPBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ABP";
}
