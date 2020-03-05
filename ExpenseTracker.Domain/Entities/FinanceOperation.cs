using System;
using System.ComponentModel.DataAnnotations;
using ExpenseTracker.Domain.Entities.Base;
using ExpenseTracker.Domain.Enums;

namespace ExpenseTracker.Domain.Entities
{
    public class FinanceOperation : BaseEntity
    {
        public Guid Id { get; set; }

        [Required]
        public FinanceOperationType Type { get; set; }

        [Required]
        public decimal Sum { get; set; }

        [Required]
        public CurrencyType Currency { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        public string Description { get; set; }

        public Guid WalletId { get; set; }

        public Wallet Wallet { get; set; }

        public Guid FinanceOperationGroupId { get; set; }

        public FinanceOperationGroup FinanceOperationGroup { get; set; }
    }
}
