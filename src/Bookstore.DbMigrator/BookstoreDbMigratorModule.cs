using Bookstore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Bookstore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BookstoreEntityFrameworkCoreModule),
    typeof(BookstoreApplicationContractsModule)
    )]
public class BookstoreDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
