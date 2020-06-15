using System;
using System.Collections.Generic;
using System.Linq;
using MyHealthLoggerInterface;
using LoggerService;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
namespace MyHealth.Extensions
{
    public static class ServiceExtension
    {
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}
