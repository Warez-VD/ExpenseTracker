using System.Linq;
using System.Threading.Tasks;
using ExpenseTracker.Application.Common.Interfaces;
using ExpenseTracker.Application.Common.Models;
using ExpenseTracker.Infrastructure.Common;
using ExpenseTracker.Infrastructure.Persistance;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Infrastructure.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> userManager;

        public IdentityService(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password)
        {
            var user = new ApplicationUser
            {
                UserName = userName,
                Email = userName,
            };

            var result = await this.userManager.CreateAsync(user, password);

            return (result.ToApplicationResult(), user.Id);
        }

        public async Task<string> GetUserNameAsync(string userId)
        {
            var user = await this.userManager.Users.FirstAsync(u => u.Id == userId);

            return user.UserName;
        }

        public async Task<Result> DeleteUserAsync(string userId)
        {
            var user = this.userManager.Users.SingleOrDefault(u => u.Id == userId);

            if (user != null)
            {
                return await DeleteUserAsync(user);
            }

            return Result.Success();
        }

        private async Task<Result> DeleteUserAsync(ApplicationUser user)
        {
            var result = await this.userManager.DeleteAsync(user);

            return result.ToApplicationResult();
        }
    }
}
