using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FrontDesk.Models;

public partial class MinDatabaseContext : DbContext
{
    public MinDatabaseContext()
    {
    }

    public MinDatabaseContext(DbContextOptions<MinDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=tcp:sofjeld.database.windows.net,1433;Initial Catalog=MinDatabase;User ID=sofjeld;Password=MinAzureDatabase1;Encrypt=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reservation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reservat__3213E83F90AC9DD5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FromDate)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ToDate)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.PersonNavigation).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.Person)
                .HasConstraintName("FK__Reservati__Perso__68487DD7");

            entity.HasOne(d => d.RoomNavigation).WithMany(p => p.Reservations)
                .HasForeignKey(d => d.Room)
                .HasConstraintName("FK__Reservatio__Room__693CA210");
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.HasKey(e => e.roomnumber).HasName("PK__Room__20A5E499B0128DA4");

            entity.ToTable("Room");

            entity.Property(e => e.roomnumber)
                .ValueGeneratedNever()
                .HasColumnName("roomnumber");
            entity.Property(e => e.Numberofbeds).HasColumnName("numberofbeds");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Size)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("size");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Users__3213E83FD0930459");

            entity.Property(e => e.id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.username)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
