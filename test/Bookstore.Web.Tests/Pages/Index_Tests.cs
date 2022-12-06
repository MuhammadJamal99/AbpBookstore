using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Bookstore.Pages;

public class Index_Tests : BookstoreWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
