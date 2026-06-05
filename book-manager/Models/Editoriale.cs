using System;
using System.Collections.Generic;

namespace book_manager.Models;

public partial class Editoriale
{
    public string Nit { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string? Telefono { get; set; }

    public string? Direccion { get; set; }

    public string? Email { get; set; }

    public string? SitioWeb { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
