using System;
using System.Collections.Generic;

namespace ExamenMVC.Models;

public partial class Autore
{
    public int IdAutor { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Apellido { get; set; }

    public string? Email { get; set; }

    public string? Nacionalidad { get; set; }

    public virtual ICollection<Libro> Libros { get; set; } = new List<Libro>();
}
