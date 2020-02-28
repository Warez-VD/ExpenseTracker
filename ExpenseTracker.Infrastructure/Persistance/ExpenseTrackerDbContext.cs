using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using ExpenseTracker.Application.Common.Interfaces;
using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.Entities.Base;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Infrastructure.Persistance
{
    public class ExpenseTrackerDbContext : IdentityDbContext<ApplicationUser>, IExpenseTrackerDbContext
    {
        private readonly IUserService userService;
        private readonly IDateTimeService dateTimeService;

        public ExpenseTrackerDbContext(
            DbContextOptions<ExpenseTrackerDbContext> options,
            IUserService userService,
            IDateTimeService dateTimeService)
            : base(options)
        {
            this.userService = userService;
            this.dateTimeService = dateTimeService;
        }

        public DbSet<Wallet> Wallets { get; set; }

        public DbSet<FinanceOperationGroup> FinanceOperationGroups { get; set; }

        public DbSet<FinanceOperation> FinanceOperations { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = this.userService.UserId;
                        entry.Entity.CreatedOn = this.dateTimeService.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = this.userService.UserId;
                        entry.Entity.ModifiedOn = this.dateTimeService.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
