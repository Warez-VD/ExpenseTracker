using System;

namespace ExpenseTracker.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public DateTime CreatedOn { get; set; }

        public Guid CreatedBy { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public Guid? ModifiedBy { get; set; }
    }
}
