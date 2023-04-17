using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarNextJsBackEnd.Entities
{
    public class ApplicationDbContext : DbContext, IDataProtectionKeyContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PurchaseOrder>()
                .HasOne(x => x.User)
                .WithMany(x => x.PurchaseOrders)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            var status1 = new PurchaseOrderStatus
            {
                Id = "Dipesan",
            };
            var status2 = new PurchaseOrderStatus
            {
                Id = "Dibayar",
            };
            var status3 = new PurchaseOrderStatus
            {
                Id = "Dikonfirmasi",
            };
            var status4 = new PurchaseOrderStatus
            {
                Id = "Dikirim",
            };
            var status5 = new PurchaseOrderStatus
            {
                Id = "Selesai",
            };
            var status6 = new PurchaseOrderStatus
            {
                Id = "Dikomplain",
            };

            modelBuilder.Entity<PurchaseOrderStatus>().HasData(status1, status2, status3, status4, status5, status6);
        }

        public DbSet<User> Users => Set<User>();

        public DbSet<Restaurant> Restaurants => Set<Restaurant>();

        public DbSet<Cart> Carts => Set<Cart>();

        public DbSet<FoodItem> FoodItems => Set<FoodItem>();

        public DbSet<CartDetail> CartDetails => Set<CartDetail>();

        public DbSet<DataProtectionKey> DataProtectionKeys => Set<DataProtectionKey>();
    }
}
