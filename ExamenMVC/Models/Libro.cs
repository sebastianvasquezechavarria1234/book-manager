using System;
using System.Collections.Generic;

namespace ExamenMVC.Models;

public partial class Libro
{
    public string Isbn { get; set; } = null!;

    public string Titulo { get; set; } = null!;

    public string? Descripcion { get; set; }

    public int? Publicacion { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public int? CodigoCategoria { get; set; }

    public string? NitEditorial { get; set; }

    public int? IdAutor { get; set; }

    public virtual Categoria? CodigoCategoriaNavigation { get; set; }

    public virtual Autore? IdAutorNavigation { get; set; }

    public virtual Editoriale? NitEditorialNavigation { get; set; }
}
