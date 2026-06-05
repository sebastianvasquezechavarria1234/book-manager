using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExamenMVC.Models;

public partial class CrudSebastianVasquezContext : DbContext
{
    public CrudSebastianVasquezContext()
    {
    }

    public CrudSebastianVasquezContext(DbContextOptions<CrudSebastianVasquezContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autore> Autores { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Editoriale> Editoriales { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autore>(entity =>
        {
            entity.HasKey(e => e.IdAutor).HasName("PK__Autores__3D64C92C0DCA8899");

            entity.Property(e => e.IdAutor).HasColumnName("Id_autor");
            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nacionalidad).HasMaxLength(50);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.CodigoCategoria).HasName("PK__Categori__738F04AD48463E60");

            entity.Property(e => e.CodigoCategoria)
                .ValueGeneratedNever()
                .HasColumnName("Codigo_categoria");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Editoriale>(entity =>
        {
            entity.HasKey(e => e.Nit).HasName("PK__Editoria__C7D1D6DB5F16C852");

            entity.Property(e => e.Nit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Direccion).HasMaxLength(200);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombres).HasMaxLength(100);
            entity.Property(e => e.SitioWeb).HasMaxLength(100);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Libro>(entity =>
        {
            entity.HasKey(e => e.Isbn).HasName("PK__Libros__9271CED127B2B3C6");

            entity.Property(e => e.Isbn)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodigoCategoria).HasColumnName("Codigo_categoria");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.FechaRegistro).HasColumnName("Fecha_registro");
            entity.Property(e => e.IdAutor).HasColumnName("Id_autor");
            entity.Property(e => e.NitEditorial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Nit_editorial");
            entity.Property(e => e.Titulo).HasMaxLength(200);

            entity.HasOne(d => d.CodigoCategoriaNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.CodigoCategoria)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Libros_Categorias");

            entity.HasOne(d => d.IdAutorNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.IdAutor)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Libros_Autores");

            entity.HasOne(d => d.NitEditorialNavigation).WithMany(p => p.Libros)
                .HasForeignKey(d => d.NitEditorial)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Libros_Editoriales");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
