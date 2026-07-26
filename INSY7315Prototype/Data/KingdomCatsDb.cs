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

        //public DbSet<User> Users { get; set; }

        // public DbSet<Cat> Cats { get; set; }
        // public DbSet<Booking> Bookings { get; set; }
        public DbSet<Cat> Cats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var blobBase = "https://kingdomcatsstorage.blob.core.windows.net/kingdomcatssanctuarycontainer";

            modelBuilder.Entity<Cat>().HasData(
                new Cat
                {
                    Id = 1,
                    Name = "Oliver",
                    AgeDisplay = "2 Years",
                    Gender = "Male",
                    Category = "Adult",
                    Badge = "New Arrival",
                    TagsCsv = "Cuddly,Indoor Only",
                    PhotoUrl = $"{blobBase}/blob1.jpeg"
                },
                new Cat
                {
                    Id = 2,
                    Name = "Luna",
                    AgeDisplay = "4 Years",
                    Gender = "Female",
                    Category = "Adult",
                    Badge = "Staff Favorite",
                    TagsCsv = "Playful,Good with Dogs",
                    PhotoUrl = $"{blobBase}/blob2.jpeg"
                },
                new Cat
                {
                    Id = 3,
                    Name = "Mochi",
                    AgeDisplay = "6 Months",
                    Gender = "Female",
                    Category = "Kitten",
                    Badge = null,
                    TagsCsv = "Energetic,Vocal",
                    PhotoUrl = $"{blobBase}/blob3.jpeg"
                },
                new Cat
                {
                    Id = 4,
                    Name = "Whiskers",
                    AgeDisplay = "9 Years",
                    Gender = "Male",
                    Category = "Senior",
                    Badge = null,
                    TagsCsv = "Calm,Lap Cat",
                    PhotoUrl = $"{blobBase}/blob4.jpeg"
                },
                new Cat
                {
                    Id = 5,
                    Name = "Patch",
                    AgeDisplay = "1 Year",
                    Gender = "Male",
                    Category = "SpecialNeeds",
                    Badge = null,
                    TagsCsv = "Special Needs,Gentle",
                    PhotoUrl = $"{blobBase}/blob5.jpeg"
                },

                new Cat
                {
                    Id = 6,
                    Name = "Patch",
                    AgeDisplay = "1 Year",
                    Gender = "Male",
                    Category = "SpecialNeeds",
                    Badge = null,
                    TagsCsv = "Special Needs,Gentle",
                    PhotoUrl = $"{blobBase}/blob6.jpeg"
                },

                 new Cat
                 {
                     Id = 7,
                     Name = "Patch",
                     AgeDisplay = "1 Year",
                     Gender = "Male",
                     Category = "SpecialNeeds",
                     Badge = null,
                     TagsCsv = "Special Needs,Gentle",
                     PhotoUrl = $"{blobBase}/blob7.jpeg"
                 },
                  new Cat
                  {
                      Id = 8,
                      Name = "Patch",
                      AgeDisplay = "1 Year",
                      Gender = "Male",
                      Category = "SpecialNeeds",
                      Badge = null,
                      TagsCsv = "Special Needs,Gentle",
                      PhotoUrl = $"{blobBase}/blob8.jpeg"
                  },
                   new Cat
                   {
                       Id = 9,
                       Name = "Patch",
                       AgeDisplay = "1 Year",
                       Gender = "Male",
                       Category = "SpecialNeeds",
                       Badge = null,
                       TagsCsv = "Special Needs,Gentle",
                       PhotoUrl = $"{blobBase}/blob9.jpeg"
                   },
                    new Cat
                    {
                        Id = 10,
                        Name = "Patch",
                        AgeDisplay = "1 Year",
                        Gender = "Male",
                        Category = "SpecialNeeds",
                        Badge = null,
                        TagsCsv = "Special Needs,Gentle",
                        PhotoUrl = $"{blobBase}/blob10.jpeg"
                    },
                     new Cat
                     {
                         Id = 11,
                         Name = "Patch",
                         AgeDisplay = "1 Year",
                         Gender = "Male",
                         Category = "SpecialNeeds",
                         Badge = null,
                         TagsCsv = "Special Needs,Gentle",
                         PhotoUrl = $"{blobBase}/blob11.jpeg"
                     }
                      //new Cat
                      //{
                      //    Id = 5,
                      //    Name = "Patch",
                      //    AgeDisplay = "1 Year",
                      //    Gender = "Male",
                      //    Category = "SpecialNeeds",
                      //    Badge = null,
                      //    TagsCsv = "Special Needs,Gentle",
                      //    PhotoUrl = $"{blobBase}/blob5.jpeg"
                      //},
                     
                      // new Cat
                      // {
                      //     Id = 5,
                      //     Name = "Patch",
                      //     AgeDisplay = "1 Year",
                      //     Gender = "Male",
                      //     Category = "SpecialNeeds",
                      //     Badge = null,
                      //     TagsCsv = "Special Needs,Gentle",
                      //     PhotoUrl = $"{blobBase}/blob5.jpeg"
                      // },
                      //  new Cat
                      //  {
                      //      Id = 5,
                      //      Name = "Patch",
                      //      AgeDisplay = "1 Year",
                      //      Gender = "Male",
                      //      Category = "SpecialNeeds",
                      //      Badge = null,
                      //      TagsCsv = "Special Needs,Gentle",
                      //      PhotoUrl = $"{blobBase}/blob5.jpeg"
                      //  },
                      //   new Cat
                      //   {
                      //       Id = 5,
                      //       Name = "Patch",
                      //       AgeDisplay = "1 Year",
                      //       Gender = "Male",
                      //       Category = "SpecialNeeds",
                      //       Badge = null,
                      //       TagsCsv = "Special Needs,Gentle",
                      //       PhotoUrl = $"{blobBase}/blob5.jpeg"
                      //   },
                      //    new Cat
                      //    {
                      //        Id = 5,
                      //        Name = "Patch",
                      //        AgeDisplay = "1 Year",
                      //        Gender = "Male",
                      //        Category = "SpecialNeeds",
                      //        Badge = null,
                      //        TagsCsv = "Special Needs,Gentle",
                      //        PhotoUrl = $"{blobBase}/blob5.jpeg"
                      //    },
                      //     new Cat
                      //     {
                      //         Id = 5,
                      //         Name = "Patch",
                      //         AgeDisplay = "1 Year",
                      //         Gender = "Male",
                      //         Category = "SpecialNeeds",
                      //         Badge = null,
                      //         TagsCsv = "Special Needs,Gentle",
                      //         PhotoUrl = $"{blobBase}/blob5.jpeg"
                      //     },
                      //      new Cat
                      //      {
                      //          Id = 5,
                      //          Name = "Patch",
                      //          AgeDisplay = "1 Year",
                      //          Gender = "Male",
                      //          Category = "SpecialNeeds",
                      //          Badge = null,
                      //          TagsCsv = "Special Needs,Gentle",
                      //          PhotoUrl = $"{blobBase}/blob5.jpeg"
                      //      },

            );
        }
    }
}
   
