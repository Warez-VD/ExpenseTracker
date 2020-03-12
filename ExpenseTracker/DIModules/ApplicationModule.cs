using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ExpenseTracker.UI.DIModules
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
