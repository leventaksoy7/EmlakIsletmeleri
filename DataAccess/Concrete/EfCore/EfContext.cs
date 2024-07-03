using EL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete.EfCore
{
    public class EfContext : DbContext
    {
        public DbSet<Workplace> Workplaces { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertySale> PropertySales { get; set; }
        public DbSet<RealEstateAgentSales> RealEstateAgentSales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=ATMACA\\SQLEXPRESS; Initial Catalog=FonetEmlakAppDb; Integrated Security=True; Trust Server Certificate=True");
        }

        //public DbSet<Workplace> Workplaces { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<Property> Properties { get; set; }
        //public DbSet<PropertySale> PropertySales { get; set; }
        //public DbSet<RealEstateAgentSales> RealEstateAgentSales { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseOracle("User Id=system;Password=01072024;Data Source=localhost:1521/XEPDB1");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property>()
                .HasOne(p => p.Owner)
                .WithMany(c => c.OwnedProperties)
                .HasForeignKey(p => p.OwnerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Property>()
                .HasOne(p => p.TenantCustomer)
                .WithMany(c => c.RentedProperties)
                .HasForeignKey(p => p.TenantCustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PropertySale>()
                .HasOne(ps => ps.Property)
                .WithMany(p => p.PropertySales)
                .HasForeignKey(ps => ps.PropertyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PropertySale>()
                .HasOne(ps => ps.SellerCustomer)
                .WithMany(c => c.SalesAsSeller)
                .HasForeignKey(ps => ps.SellerCustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PropertySale>()
                .HasOne(ps => ps.BuyerCustomer)
                .WithMany(c => c.SalesAsBuyer)
                .HasForeignKey(ps => ps.BuyerCustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PropertySale>()
                .HasOne(ps => ps.RealEstateAgent)
                .WithMany(w => w.Sales)
                .HasForeignKey(ps => ps.RealEstateAgentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RealEstateAgentSales>()
                .HasOne(ras => ras.RealEstateAgent)
                .WithMany()
                .HasForeignKey(ras => ras.RealEstateAgentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RealEstateAgentSales>()
                .HasOne(ras => ras.PropertySale)
                .WithMany()
                .HasForeignKey(ras => ras.PropertySaleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
