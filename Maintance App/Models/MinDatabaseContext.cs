using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Maintance_App.Models;

public partial class MinDatabaseContext : DbContext
{
    public MinDatabaseContext()
    {
    }

    public MinDatabaseContext(DbContextOptions<MinDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cleaning> Cleanings { get; set; }

    public virtual DbSet<Maintenance> Maintenances { get; set; }

    public virtual DbSet<Reservation> Reservations { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:sofjeld.database.windows.net,1433;Initial Catalog=MinDatabase;User ID=sofjeld;Password=MinAzureDatabase1;Encrypt=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cleaning>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cleaning__3213E83F2FFD9F5A");

            entity.ToTable("Cleaning");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Request)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("request");
            entity.Property(e => e.Room).HasColumnName("room");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("status");

            entity.HasOne(d => d.RoomNavigation).WithMany(p => p.Cleanings)
                .HasForeignKey(d => d.Room)
                .HasConstraintName("FK__Cleaning__room__6FE99F9F");
        });

        modelBuilder.Entity<Maintenance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Maintena__3213E83F04948223");

            entity.ToTable("Maintenance");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Request)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("request");
            entity.Property(e => e.Room).HasColumnName("room");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("status");

            entity.HasOne(d => d.RoomNavigation).WithMany(p => p.Maintenances)
                .HasForeignKey(d => d.Room)
                .HasConstraintName("FK__Maintenanc__room__72C60C4A");
        });

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
            entity.HasKey(e => e.Roomnumber).HasName("PK__Room__20A5E499B0128DA4");

            entity.ToTable("Room");

            entity.Property(e => e.Roomnumber)
                .ValueGeneratedNever()
                .HasColumnName("roomnumber");
            entity.Property(e => e.Numberofbeds).HasColumnName("numberofbeds");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Size)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("size");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Service__3213E83F56C9D1C9");

            entity.ToTable("Service");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Request)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("request");
            entity.Property(e => e.Room).HasColumnName("room");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("status");

            entity.HasOne(d => d.RoomNavigation).WithMany(p => p.Services)
                .HasForeignKey(d => d.Room)
                .HasConstraintName("FK__Service__room__75A278F5");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3213E83FD0930459");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
