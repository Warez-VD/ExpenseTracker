using System;
using ExpenseTracker.Application.Common.Interfaces;

namespace ExpenseTracker.Infrastructure.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime Now 
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
