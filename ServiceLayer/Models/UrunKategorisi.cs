using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class UrunKategorisi
{
    public int UrunKategorisiId { get; set; }

    public int UrunId { get; set; }

    public string AnaKategoriAdi { get; set; } = null!;

    public string? UrunKategorisiAdi { get; set; }

    public virtual Urun Urun { get; set; } = null!;
}
