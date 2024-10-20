using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projekt_garaze.Models;

namespace Projekt_garaze.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Projekt_garaze.Models.Owner> Owner { get; set; } = default!;
        public DbSet<Projekt_garaze.Models.Garage> Garage { get; set; } = default!;
        public DbSet<Projekt_garaze.Models.Car> Car { get; set; } = default!;
    }
}
