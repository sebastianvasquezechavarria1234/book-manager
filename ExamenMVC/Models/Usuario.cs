using System;
using System.Collections.Generic;

namespace ExamenMVC.Models;

public partial class Usuario
{
    public int AnimalId { get; set; }

    public string? Nombre { get; set; }

    public string? Especie { get; set; }

    public int? Edad { get; set; }
}
