using System;

namespace ExpenseTracker.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public DateTime ModifiedOn { get; set; }

        public string ModifiedBy { get; set; }
    }
}
