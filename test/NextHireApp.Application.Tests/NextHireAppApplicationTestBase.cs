using Volo.Abp.Modularity;

namespace NextHireApp;

public abstract class NextHireAppApplicationTestBase<TStartupModule> : NextHireAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
