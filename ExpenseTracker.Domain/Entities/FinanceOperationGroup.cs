using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ExpenseTracker.Domain.Entities.Base;

namespace ExpenseTracker.Domain.Entities
{
    public class FinanceOperationGroup : BaseEntity
    {
        public FinanceOperationGroup()
        {
            this.FinanceOperations = new HashSet<FinanceOperation>();
        }

        public Guid Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(255)]
        public string Name { get; set; }

        public ICollection<FinanceOperation> FinanceOperations { get; set; }
    }
}
