using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace InventorySystem.Models.Database;

public partial class InventoryOrderDbContext : DbContext
{
    public InventoryOrderDbContext()
    {
    }

    public InventoryOrderDbContext(DbContextOptions<InventoryOrderDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CustomersTable> CustomersTables { get; set; }

    public virtual DbSet<OrdersTable> OrdersTables { get; set; }

    public virtual DbSet<ProductsTable> ProductsTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-TM6EI00;Database=InventoryOrderDb;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CustomersTable>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK_Customers");

            entity.ToTable("CustomersTable");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OrdersTable>(entity =>
        {
            entity.HasKey(e => e.OrdersId).HasName("PK_Orders");

            entity.ToTable("OrdersTable");

            entity.Property(e => e.OrdersId).ValueGeneratedNever();

            entity.HasOne(d => d.Customers).WithMany(p => p.OrdersTables)
                .HasForeignKey(d => d.CustomersId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Customers");

            entity.HasOne(d => d.Products).WithMany(p => p.OrdersTables)
                .HasForeignKey(d => d.ProductsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Products1");
        });

        modelBuilder.Entity<ProductsTable>(entity =>
        {
            entity.HasKey(e => e.ProductsId).HasName("PK_Products");

            entity.ToTable("ProductsTable");

            entity.HasIndex(e => e.Barcode, "IX_Products").IsUnique();

            entity.Property(e => e.ProductsId).ValueGeneratedNever();
            entity.Property(e => e.Barcode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
