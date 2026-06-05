using System;
using System.Collections.Generic;

namespace book_manager.Models;

public partial class Animale
{
    public int AnimalId { get; set; }

    public string? Nombre { get; set; }

    public string? Especie { get; set; }

    public int? Edad { get; set; }
}
