using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Backend.Database.TransactionDB1Entities;

public partial class TransactionDb1Context : DbContext
{
    public TransactionDb1Context()
    {
    }

    public TransactionDb1Context(DbContextOptions<TransactionDb1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<TrBpkb> TrBpkbs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-K14UJU5Q\\FIDEL;initial catalog=Transaction_DB_1;persist security info=True;user id=sa;password=online; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TrBpkb>(entity =>
        {
            entity.HasKey(e => e.AgreementNumber);

            entity.ToTable("tr_bpkb", tb => tb.HasTrigger("tr_bpkb_location"));

            entity.Property(e => e.AgreementNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("agreement_number");
            entity.Property(e => e.BpkbDate)
                .HasColumnType("datetime")
                .HasColumnName("bpkb_date");
            entity.Property(e => e.BpkbDateIn)
                .HasColumnType("datetime")
                .HasColumnName("bpkb_date_in");
            entity.Property(e => e.BpkbNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("bpkb_no");
            entity.Property(e => e.BranchId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("branch_id");
            entity.Property(e => e.FakturDate)
                .HasColumnType("datetime")
                .HasColumnName("faktur_date");
            entity.Property(e => e.FakturNo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("faktur_no");
            entity.Property(e => e.LocationId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("location_id");
            entity.Property(e => e.PoliceNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("police_no");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
