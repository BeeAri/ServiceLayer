using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class Sipari
{
    public int SiparisId { get; set; }

    public int MusteriId { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public int ParaBirimiId { get; set; }

    public decimal ToplamTutar { get; set; }

    public string? SiparisDetayi { get; set; }

    public int SiparisDurumuId { get; set; }

    public virtual Musteri Musteri { get; set; } = null!;

    public virtual ParaBirimi ParaBirimi { get; set; } = null!;

    public virtual SiparisDurumu SiparisDurumu { get; set; } = null!;

    public virtual ICollection<Tahsilat> Tahsilats { get; } = new List<Tahsilat>();
}
