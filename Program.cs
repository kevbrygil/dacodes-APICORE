using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using dacodes_APICORE.Models;

namespace dacodes_APICORE
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateHostBuilder(args).Build().Run();
            var host_builder = CreateHostBuilder(args).Build();
            using(var scope = host_builder.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
        
                var context = services.GetRequiredService<ApiDbContext>();
                var logger = services.GetRequiredService<ILogger<Program>>();
        
                try
                {
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, "Error ocurrido al crear la base de datos.");
                }
            }
        
            host_builder.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
