using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ExpenseTracker.Domain.Entities.Base;

namespace ExpenseTracker.Domain.Entities
{
    public class Wallet : BaseEntity
    {
        public Wallet()
        {
            this.FinanceOperations = new HashSet<FinanceOperation>();
        }

        public string Id { get; set; }

        [MaxLength(40)]
        public string Name { get; set; }

        public decimal Amount { get; set; }

        public ICollection<FinanceOperation> FinanceOperations { get; set; }
    }
}
