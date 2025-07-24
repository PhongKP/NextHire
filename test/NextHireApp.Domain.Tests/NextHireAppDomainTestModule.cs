using Volo.Abp.Modularity;

namespace NextHireApp;

[DependsOn(
    typeof(NextHireAppDomainModule),
    typeof(NextHireAppTestBaseModule)
)]
public class NextHireAppDomainTestModule : AbpModule
{

}
