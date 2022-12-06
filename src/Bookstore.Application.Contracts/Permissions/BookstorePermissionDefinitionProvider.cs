using Bookstore.Localization;
using Bookstore.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.BookStore.Permissions
{
    public class BookStorePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var bookStoreGroup = context.AddGroup(BookstorePermissions.GroupName, L("Permission:Bookstore"));

            var booksPermission = bookStoreGroup.AddPermission(BookstorePermissions.Books.Default, L("Permission:Books"));
            booksPermission.AddChild(BookstorePermissions.Books.Create, L("Permission:Books.Create"));
            booksPermission.AddChild(BookstorePermissions.Books.Edit, L("Permission:Books.Edit"));
            booksPermission.AddChild(BookstorePermissions.Books.Delete, L("Permission:Books.Delete"));

            //author permission
            var authorsPermission = bookStoreGroup.AddPermission(
    BookstorePermissions.Authors.Default, L("Permission:Authors"));

            authorsPermission.AddChild(
                BookstorePermissions.Authors.Create, L("Permission:Authors.Create"));

            authorsPermission.AddChild(
                BookstorePermissions.Authors.Edit, L("Permission:Authors.Edit"));

            authorsPermission.AddChild(
                BookstorePermissions.Authors.Delete, L("Permission:Authors.Delete"));

        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<BookstoreResource>(name);
        }
    }
}
