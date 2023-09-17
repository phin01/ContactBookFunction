using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureAppConfiguration(config =>
    {
        config.AddJsonFile("appsettings.json", optional: true);
        config.AddJsonFile("local.settings.json", optional: true);
        config.AddEnvironmentVariables();
    })
    .Build();

host.Run();
