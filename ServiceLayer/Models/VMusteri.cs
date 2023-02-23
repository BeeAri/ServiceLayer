using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ServiceLayer.Models;

public partial class VMusteri
{
    public int MusteriId { get; set; }

    public string MusteriAdi { get; set; } = null!;

    public string MusteriSoyadi { get; set; } = null!;

    public int CinsiyetId { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public string? Adres { get; set; }

    public int SehirId { get; set; }

    public string? Email { get; set; }

    public string? Gsm { get; set; }

    public virtual Cinsiyet Cinsiyet { get; set; } = null!;

    [JsonIgnore]
    public virtual Sehir MusteriNavigation { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<Odeme> Odemes { get; } = new List<Odeme>();

    [JsonIgnore]
    public virtual ICollection<Sipari> Siparis { get; } = new List<Sipari>();

    [JsonIgnore]
    public virtual ICollection<Tahsilat> Tahsilats { get; } = new List<Tahsilat>();
}
