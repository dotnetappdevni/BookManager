using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BookManager.Models;
using System.Xml;
using Microsoft.Extensions.Configuration;
using BookManager.DAL;
using System.Reflection.Emit;
using static BookManager.Models.Enums;

namespace BookManager.Domain
{
    public class ApplicationDBContext : IdentityDbContext<IdentityUser>
    {
        
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Ref_Category> Ref_Categorys { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<BookInventory> BookInventories { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<BooksLoaned> BooksLoaned { get; set; }
        public DbSet<Book> Books { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(new Customer { Id = 10, Forename = "The", Surname = "Doctor" ,IsActive=true,IsDeleted=false});
            modelBuilder.Entity<Customer>().HasData(new Customer { Id = 11, Forename = "Martha", Surname = "Jones", IsActive = true, IsDeleted = false });
            modelBuilder.Entity<Customer>().HasData(new Customer { Id = 12, Forename = "Amy", Surname = "Pond", IsActive = true, IsDeleted = false });
            modelBuilder.Entity<Customer>().HasData(new Customer { Id = 13, Forename = "River", Surname = "Song", IsActive = true, IsDeleted = false });


            modelBuilder.Entity<BookInventory>().HasData(new BookInventory { Id = 3, BookId= 3, BarCode = "1111", InventoryCount=10, DateCreated = DateTime.Now,IsActive = true,IsDeleted=false});
            modelBuilder.Entity<BookInventory>().HasData(new BookInventory { Id = 4, BookId = 4, BarCode = "3333", InventoryCount = 5, DateCreated = DateTime.Now, IsActive = true, IsDeleted = false });
            modelBuilder.Entity<BookInventory>().HasData(new BookInventory { Id = 5, BookId = 5, BarCode = "4444", InventoryCount = 9, DateCreated = DateTime.Now, IsActive = true, IsDeleted = false });

            // Add initial data
            modelBuilder.Entity<Book>().HasData(
               new Book { Id = 3, ISBN = "329-320-2392-1", BarCode = "1111", Genre = (int)BookGenreEnum.ScienceFiction, Title = "Star Trek - Beyond", Description = "After stopping off at Starbase Yorktown, a remote outpost on the fringes of Federation space, the USS Enterprise, halfway into their five-year mission, is destroyed by an unstoppable wave of unknown aliens.", IsDeleted = false, IsActive = true, DateCreated = DateTime.Now, DateModified = DateTime.Now, Type = 1, Price = 15.99m },
           new Book
           {
               Id = 4,
               BarCode = "3333",
               ISBN = "978-0-671-56743-1",
               Title = "Star Trek - First Contact",
               Description = "The novelization of the \"First Contact\" film which also includes a behind-the-scenes look at the making of the film. Captain Pickard, Commander Riker, Lieutenant Commander Data and the rest of the crew must face their greatest foe, the half-organic, half-mechanical Borg..",
               IsDeleted = false,
               IsActive = true,
               DateCreated = DateTime.Now,
               DateModified = DateTime.Now,
               Genre = (int)BookGenreEnum.ScienceFiction,
               Price = 10.99m
           },
             new Book
             {
                 Id = 5,
                 BarCode = "4444",
                 ISBN = "978-1-84607-571-7",
                 Title = "Doctor Who: The Star Beast ",
                 Description = "Landing on Earth, the Doctor finds a stranded alien in need of protection – and is dragged headlong into the life of his old friend Donna Noble, knowing that if she ever remembers their time together, she will die…",
                 IsDeleted = false,
                 IsActive = true,
                 DateCreated = DateTime.Now,
                 DateModified = DateTime.Now,               
                 Genre = (int)BookGenreEnum.ScienceFiction,
                 Price = 16.00m
             });

            this.SeedUsers(modelBuilder);
          

        }

        private void SeedUsers(ModelBuilder modelBuilder)
        {
            //Seeding a  'Administrator' role to AspNetRoles table
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Administrator", NormalizedName = "ADMINISTRATOR".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            { Id = "8cc980c3-8643-4166-8dcb-de924036ec6b", Name = "Staff", NormalizedName = "Staff".ToUpper() });

            //a hasher to hash the password before seeding the user to the db
            var hasher = new PasswordHasher<IdentityUser>();

            //Seeding the Admin user to AspNetUsers table
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9", // primary key
                    UserName = "edt@dotnetappdevni.com",
                    Email = "edt@dotnetappdevni.com",
                    NormalizedEmail = "EDT@DOTNETAPPDEVNI.COM",
                    NormalizedUserName = "ADMIN",
                    LockoutEnabled = false,
                    PasswordHash = hasher.HashPassword(null, "Test12345!@")
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
          new IdentityUserRole<string>
          {
              RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
              UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"
          }
      );


            //Seeding the relation staff Member between our user and role to AspNetUserRoles table

            modelBuilder.Entity<IdentityUser>().HasData(
             new IdentityUser
             {
                 Id = "d18e858a-c38d-4083-99b6-c5697b81d7cd", // primary key
                 UserName = "Staff",
                 Email = "Staff@EDT.COM",
                 NormalizedEmail = "STAFF@EDT.COM",
                 NormalizedUserName = "STAFF",
                 PasswordHash = hasher.HashPassword(null, "Test12345!@")
             }
         );

              modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "8cc980c3-8643-4166-8dcb-de924036ec6b",
                    UserId = "d18e858a-c38d-4083-99b6-c5697b81d7cd"
                }
            );


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();


        }
    }
}
