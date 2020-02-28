using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Application.Common.Interfaces
{
    public interface IExpenseTrackerDbContext
    {
        DbSet<Wallet> Wallets { get; set; }

        DbSet<FinanceOperationGroup> FinanceOperationGroups { get; set; }

        DbSet<FinanceOperation> FinanceOperations { get; set; }
    }
}
