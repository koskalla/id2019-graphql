using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NobelPriceData.Models
{
    public partial class NobelDataContext : DbContext
    {
        public NobelDataContext()
        {
        }

        public NobelDataContext(DbContextOptions<NobelDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<NobelPrizes> NobelPrizes { get; set; }
        public virtual DbSet<NobelWinners> NobelWinners { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=graphql-demo.database.windows.net;Database=NobelData;user id=developer03;password=03developer!;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NobelPrizes>(entity =>
            {
                entity.ToTable("nobelPrizes");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(255);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(255);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(255);

                entity.Property(e => e.Motivation)
                    .HasColumnName("motivation")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Share).HasColumnName("share");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<NobelWinners>(entity =>
            {
                entity.ToTable("nobelWinners");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Born)
                    .HasColumnName("born")
                    .HasMaxLength(255);

                entity.Property(e => e.BornCity)
                    .HasColumnName("bornCity")
                    .HasMaxLength(255);

                entity.Property(e => e.BornCountry)
                    .HasColumnName("bornCountry")
                    .HasMaxLength(255);

                entity.Property(e => e.BornCountryCode)
                    .HasColumnName("bornCountryCode")
                    .HasMaxLength(255);

                entity.Property(e => e.Died)
                    .HasColumnName("died")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiedCity)
                    .HasColumnName("diedCity")
                    .HasMaxLength(255);

                entity.Property(e => e.DiedCountry)
                    .HasColumnName("diedCountry")
                    .HasMaxLength(255);

                entity.Property(e => e.DiedCountryCode)
                    .HasColumnName("diedCountryCode")
                    .HasMaxLength(255);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(255);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(255);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(255);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.NobelWinners)
                    .HasForeignKey<NobelWinners>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sheet1$__id__6A30C649");
            });
        }
    }
}
