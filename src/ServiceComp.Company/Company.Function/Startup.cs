using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Company.Function.Startup))]
namespace Company.Function
{
    public class Startup: FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddHttpClient();

            // builder.Services.AddSingleton<IMyService>((s) => {
            //     return new MyService();
            // });
            //
            // builder.Services.AddSingleton<ILoggerProvider, MyLoggerProvider>();
        }
    }
}