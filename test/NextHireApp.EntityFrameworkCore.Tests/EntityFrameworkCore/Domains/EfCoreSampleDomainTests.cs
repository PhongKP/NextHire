using NextHireApp.Samples;
using Xunit;

namespace NextHireApp.EntityFrameworkCore.Domains;

[Collection(NextHireAppTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<NextHireAppEntityFrameworkCoreTestModule>
{

}
