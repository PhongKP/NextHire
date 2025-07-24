using Xunit;

namespace NextHireApp.EntityFrameworkCore;

[CollectionDefinition(NextHireAppTestConsts.CollectionDefinitionName)]
public class NextHireAppEntityFrameworkCoreCollection : ICollectionFixture<NextHireAppEntityFrameworkCoreFixture>
{

}
