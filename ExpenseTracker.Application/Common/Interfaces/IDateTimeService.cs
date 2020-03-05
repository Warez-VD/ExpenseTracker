using System;

namespace ExpenseTracker.Application.Common.Interfaces
{
    public interface IDateTimeService
    {
        DateTime Now { get; }
    }
}
