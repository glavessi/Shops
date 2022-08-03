using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Shops.Data.EF.Model;

#nullable disable

namespace Shops.Data.EF.Data
{
    public partial class ChallengeDBContext : DbContext
    {
        public ChallengeDBContext()
        {
        }

        public ChallengeDBContext(DbContextOptions<ChallengeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeShop> EmployeeShops { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_EmployeeType");
            });

            modelBuilder.Entity<EmployeeShop>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.Workday })
                    .HasName("PK_EmployeeShop_1");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeShops)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_EmployeeShop");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.EmployeeShops)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Shop_EmployeeShop");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
