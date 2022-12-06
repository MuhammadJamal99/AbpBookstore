using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Bookstore.Web;

[Dependency(ReplaceServices = true)]
public class BookstoreBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Bookstore";
}
