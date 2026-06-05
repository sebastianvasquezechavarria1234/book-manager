using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExamenMVC.Models;

public partial class ExamenMvcContext : DbContext
{
    public ExamenMvcContext()
    {
    }

    public ExamenMvcContext(DbContextOptions<ExamenMvcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Animale> Animales { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-OSQK0RQ;Initial Catalog=ExamenMVC;integrated security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Animale>(entity =>
        {
            entity.HasKey(e => e.AnimalId).HasName("PK__Animales__A21A73279B97324F");

            entity.Property(e => e.AnimalId).HasColumnName("AnimalID");
            entity.Property(e => e.Especie).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.AnimalId).HasName("PK__Usuarios__A21A7327993377C0");

            entity.Property(e => e.AnimalId).HasColumnName("AnimalID");
            entity.Property(e => e.Especie).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
