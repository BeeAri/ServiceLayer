using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ServiceLayer.Models;

public partial class VUrun
{
    public int UrunId { get; set; }

    public string UrunAdi { get; set; } = null!;

    public string UrunKodu { get; set; } = null!;

    public string ParaBirimiAdi { get; set; }

    public decimal Fiyat { get; set; }

    public int StokAdedi { get; set; }

    public string? Aciklama { get; set; }

    public string? UrunKategorisiAdi { get; set; }

    public string? AnaKategoriAdi { get; set; }

    //public virtual ParaBirimi ParaBirimi { get; set; } = null!;

    //public virtual ICollection<UrunKategorisi> UrunKategorisis { get; } = new List<UrunKategorisi>();
}
