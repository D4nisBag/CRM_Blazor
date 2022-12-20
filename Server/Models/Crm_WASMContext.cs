using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Crm_WASM.Server.Models
{
    public partial class Crm_WASMContext : DbContext
    {
        public Crm_WASMContext()
        {
        }

        public Crm_WASMContext(DbContextOptions<Crm_WASMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Name=Crm_WASM");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Lastname).HasColumnName("lastname");

                entity.Property(e => e.Login).HasColumnName("login");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.PhoneNumber).HasColumnName("phone_number");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DispatchAdress).HasColumnName("dispatch_adress");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.OrderName).HasColumnName("order_name");

                entity.Property(e => e.SendingProduct).HasColumnName("sending_product");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'opened'");

                entity.Property(e => e.TargetAdress).HasColumnName("target_adress");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
