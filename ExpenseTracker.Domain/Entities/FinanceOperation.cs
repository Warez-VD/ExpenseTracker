using System.ComponentModel.DataAnnotations;
using ExpenseTracker.Domain.Entities.Base;
using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Domain.Entities
{
    public class FinanceOperation : BaseEntity
    {
        public string Id { get; set; }

        public FinanceOperationType Type { get; set; }

        public decimal Sum { get; set; }

        public CurrencyType Currency { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int WalletId { get; set; }

        public Wallet Wallet { get; set; }

        public int FinanceOperationGroupId { get; set; }

        public FinanceOperationGroup FinanceOperationGroup { get; set; }
    }
}
