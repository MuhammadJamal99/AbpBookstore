using Bookstore.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Bookstore.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class BookstorePageModel : AbpPageModel
{
    protected BookstorePageModel()
    {
        LocalizationResourceType = typeof(BookstoreResource);
    }
}
