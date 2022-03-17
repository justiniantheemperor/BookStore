using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    // sets up a class that inherits from IdentityDbContext of type IdentityUser
    public class AppIdentityDBContext : IdentityDbContext<IdentityUser>
    {
        // constructor
        public AppIdentityDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}
