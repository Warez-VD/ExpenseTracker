using System.Security.Claims;
using ExpenseTracker.Application.Common.Interfaces;
using Microsoft.AspNetCore.Http;

namespace ExpenseTracker.UI.Services
{
    public class UserService : IUserService
    {
        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            this.UserId = httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public string UserId { get; }
    }
}
