using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace Bookstore;

public class BookstoreWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<BookstoreWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
