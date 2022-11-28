﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SpendingApp.Data;

public partial class SpendingDbContext : DbContext
{
    public SpendingDbContext()
    {
    }

    public SpendingDbContext(DbContextOptions<SpendingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Spend> Spend { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SpendingDb");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Spend>(entity =>
        {
            entity.ToTable("Spend");

            entity.Property(e => e.SpendId).HasColumnName("spend_id");
            entity.Property(e => e.Dateofaddition)
                .HasColumnType("datetime")
                .HasColumnName("dateofaddition");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Paid).HasColumnName("paid");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.UsersId).HasColumnName("users_id");

            entity.HasOne(d => d.Users).WithMany(p => p.Spends)
                .HasForeignKey(d => d.UsersId)
                .HasConstraintName("FK_Spend_Users1");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UsersId);

            entity.Property(e => e.UsersId).HasColumnName("users_id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .HasColumnName("surname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
