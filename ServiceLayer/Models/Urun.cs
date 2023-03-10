using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ServiceLayer.Models;

public partial class Urun
{
    public int UrunId { get; set; }

    public string UrunAdi { get; set; } = null!;

    public string UrunKodu { get; set; } = null!;

    public int ParaBirimiId { get; set; }

    public decimal Fiyat { get; set; }

    public int StokAdedi { get; set; }

    public string? Aciklama { get; set; }

    //[JsonPropertyName("UrunKategorisiAdi")]
    public int UrunKategorisiId { get; set; }

    [JsonIgnore]
    public virtual ParaBirimi ParaBirimi { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<UrunKategorisi> UrunKategorisis { get; } = new List<UrunKategorisi>();
}
