using Volo.Abp.Modularity;

namespace NextHireApp;

[DependsOn(
    typeof(NextHireAppApplicationModule),
    typeof(NextHireAppDomainTestModule)
)]
public class NextHireAppApplicationTestModule : AbpModule
{

}
