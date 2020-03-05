using ExpenseTracker.Application.Common.Interfaces;
using ExpenseTracker.Infrastructure.Persistance;
using ExpenseTracker.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTracker.UI.DIModules
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ExpenseTrackerDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly(typeof(ExpenseTrackerDbContext).Assembly.FullName)));

            services.AddScoped<IExpenseTrackerDbContext>(provider => provider.GetService<ExpenseTrackerDbContext>());
            services.AddScoped<IDateTimeService, DateTimeService>();

            return services;
        }
    }
}
