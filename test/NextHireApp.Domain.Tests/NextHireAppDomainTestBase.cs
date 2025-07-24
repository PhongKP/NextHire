using Volo.Abp.Modularity;

namespace NextHireApp;

/* Inherit from this class for your domain layer tests. */
public abstract class NextHireAppDomainTestBase<TStartupModule> : NextHireAppTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
