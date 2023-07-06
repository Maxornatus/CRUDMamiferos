using System;
using System.Collections.Generic;

namespace CRUDMamiferos.Models;

public partial class Especy
{
    public int Id { get; set; }

    public string Especie { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public string Familia { get; set; } = null!;

    public string Orden { get; set; } = null!;

    public decimal Longitud { get; set; }

    public decimal Latitud { get; set; }
}
