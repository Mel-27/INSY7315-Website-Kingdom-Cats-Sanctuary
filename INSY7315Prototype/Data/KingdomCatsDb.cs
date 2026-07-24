using INSY7315Prototype.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace INSY7315Prototype.Data
{
   public class KingdomCatsDb : DbContext
    {
        public KingdomCatsDb(DbContextOptions<KingdomCatsDb> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

       // public DbSet<Cat> Cats { get; set; }
      // public DbSet<Booking> Bookings { get; set; }
   }
}