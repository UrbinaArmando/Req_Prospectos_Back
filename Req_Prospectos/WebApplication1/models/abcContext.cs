using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class abcContext : DbContext
    {
        public abcContext()
        {
        }

        public abcContext(DbContextOptions<abcContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Prospect> Prospects { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=URBINA;Initial Catalog=abc;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prospect>(entity =>
            {
                entity.ToTable("prospects");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.colonia)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("colonia")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.comments)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comments")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.lastName1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("last_name1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.lastName2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("last_name2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.number)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("number")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.postalCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("postal_code")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.rfc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("rfc")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("status")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.street)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("street")
                    .HasDefaultValueSql("('')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
