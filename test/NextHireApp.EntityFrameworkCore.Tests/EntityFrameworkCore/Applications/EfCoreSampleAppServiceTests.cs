using NextHireApp.Samples;
using Xunit;

namespace NextHireApp.EntityFrameworkCore.Applications;

[Collection(NextHireAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<NextHireAppEntityFrameworkCoreTestModule>
{

}
