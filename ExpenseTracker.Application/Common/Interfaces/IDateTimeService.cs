using System;

namespace ExpenseTracker.Application.Common.Interfaces
{
    public interface IDateTimeService
    {
        public DateTime Now { get; }
    }
}
