using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

//setting up seed data for an admin user
namespace Mission7.Models
{
    public static class IdentitySeedData
    {
        //create variables to use later 
        private const string adminUser = "Admin";
        private const string adminPassword = "413ExtraYeetPeriod(t)!";
        private static object userManger;



        //this method will make sure there is data in the database
        public static async void EnsurePopulated(IApplicationBuilder app)
        {
            //put in some settings into the instance named context
            AppIdentityDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<AppIdentityDBContext>();

            //if there are any pending migrations in the context instance, run the migrations
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            //setup for identity manager
            UserManager<IdentityUser> userManager = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<UserManager<IdentityUser>>();

            //find the user with the name "admin" (if there is one)
            IdentityUser user = await userManager.FindByIdAsync(adminUser);

            //if the user is null then set up new user with the following info 
            if (user == null)
            {
                user = new IdentityUser(adminUser);
                user.Email = "admin@gmail.com";
                user.PhoneNumber = "801-555-1111";

                await userManager.CreateAsync(user, adminPassword);
            }
              
        }
    }
}
