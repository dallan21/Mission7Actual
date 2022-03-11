using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mission7.Models
{
    //setting up for a user to login.
    //This class inherits from the IdentityDbContext class of type IdentityUser
    public class AppIdentityDBContext : IdentityDbContext<IdentityUser>
    {
        //set up options for this file
        public AppIdentityDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
