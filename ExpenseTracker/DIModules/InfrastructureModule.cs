using ExpenseTracker.Application.Common.Interfaces;
using ExpenseTracker.Infrastructure.Persistance;
using ExpenseTracker.Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
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

            services.AddDbContext<UserDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnector"),
                    b => b.MigrationsAssembly(typeof(UserDbContext).Assembly.FullName)));

            services.AddScoped<UserDbContext, UserDbContext>();
            services.AddScoped<IExpenseTrackerDbContext, ExpenseTrackerDbContext>();
            services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<UserDbContext>();

            services.AddScoped<IDateTimeService, DateTimeService>();

            return services;
        }
    }
}
