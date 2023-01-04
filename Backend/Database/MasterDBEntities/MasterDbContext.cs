using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Backend.Database.MasterDBEntities;

public partial class MasterDbContext : DbContext
{
    public MasterDbContext()
    {
    }

    public MasterDbContext(DbContextOptions<MasterDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MsStorageLocation> MsStorageLocations { get; set; }

    public virtual DbSet<MsUser> MsUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-K14UJU5Q\\FIDEL;initial catalog=MasterDB;persist security info=True;user id=sa;password=online; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MsStorageLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId);

            entity.ToTable("ms_storage_location");

            entity.Property(e => e.LocationId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("location_id");
            entity.Property(e => e.LocationName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("location_name");
        });

        modelBuilder.Entity<MsUser>(entity =>
        {
            entity.HasKey(e => e.UserName);

            entity.ToTable("ms_user");

            entity.Property(e => e.UserName)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("user_name");
            entity.Property(e => e.Password)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.UserType)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("user_type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
