using Chirper.Data.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chirper.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Chirp> Chirps { get; set; }
        public DbSet<UserChirp> UserChirps { get; set; }
        public DbSet<UserFollower> Followers { get; set; }
    }

}
