using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportify.DAL.Entities
{
    public class DBContext:DbContext
    {
       public  DbSet<User> users{get;set;}
        public DbSet<PlaceOfInterest> placeOfInterests{get;set;}
        public DbSet<UserPlaceOfIntrest>userPlaceOfIntrests{get;set;}
        public DbSet<Product> products{get;set;}
        public DbSet<Shop> shops{get;set;}
        public DbSet<UserProduct> UserProducts { get; set; } 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Server=.;Database=Sportify;Trusted_Connection=True;Encrypt=False");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserPlaceOfIntrest>()
                .HasKey(up => new { up.PlaceId, up.UserId }); // Composite key

            modelBuilder.Entity<UserPlaceOfIntrest>()
                .HasOne(up => up.Place)
                .WithMany(p => p.UserPlaceOfIntrests)
                .HasForeignKey(up => up.PlaceId)
            .OnDelete(DeleteBehavior.NoAction); // 👈 Cascade delete when PlaceOfInterest is deleted

            modelBuilder.Entity<UserPlaceOfIntrest>()
                .HasOne(up => up.User)
                .WithMany(u => u.UserPlaceOfInterests)
                .HasForeignKey(up => up.UserId)
                .OnDelete(DeleteBehavior.Cascade); // Avoids multiple cascade paths


         


            modelBuilder.Entity<Product>()
    .HasOne(p => p.Shop)
    .WithMany(s => s.Products)
    .HasForeignKey(p => p.ShopId)
    .OnDelete(DeleteBehavior.Cascade); // ✅ Ensures products are deleted when shop is removed

           modelBuilder.Entity<PlaceOfInterest>()
                .HasOne(p=>p.owner)
                .WithMany(u=>u.OwnerPlaces)
                .HasForeignKey(p=>p.ownerid).
                OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Shop>()
      .HasOne(s => s.Place)
      .WithMany(p => p.Shops)  
      .HasForeignKey(s => s.PlaceId)
      .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<UserProduct>()
       .HasKey(up => new { up.UserId, up.ProductId }); // Composite key

            modelBuilder.Entity<UserProduct>()
                .HasOne(up => up.User)
                .WithMany(u => u.UserProducts)
                .HasForeignKey(up => up.UserId)
                .OnDelete(DeleteBehavior.Cascade); // 👈 Cascade delete when User is deleted

            modelBuilder.Entity<UserProduct>()
                .HasOne(up => up.Product)
                .WithMany(p => p.UserProducts)
                .HasForeignKey(up => up.ProductId)
                .OnDelete(DeleteBehavior.NoAction); // 👈 Prevents cycle error

        }

    }
}
