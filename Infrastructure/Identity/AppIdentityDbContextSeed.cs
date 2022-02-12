using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Pablo",
                    Email = "pablo@test.com",
                    UserName = "pablo@test.com",
                    Address = new Address{
                        FirstName = "Pablo",
                        LastName = "Pablillo",
                        Street = "Siempre viva 123",
                        City = "Springfield",
                        State = "SF",
                        ZipCode = "902"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}