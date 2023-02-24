using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ServiceLayer.Models;

public partial class VMusteri
{
    public int MusteriId { get; set; }

    public string MusteriAdi { get; set; } = null!;

    public string MusteriSoyadi { get; set; } = null!;

    //public int CinsiyetId { get; set; }
    public string CinsiyetAdi { get; set; }
    public DateTime? DogumTarihi { get; set; }

    public string? Adres { get; set; }

    public string SehirAdi { get; set; }

    public string? Email { get; set; }

    public string? Gsm { get; set; }

}
