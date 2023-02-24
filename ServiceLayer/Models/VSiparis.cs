using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class VSiparis
{
    public int SiparisId { get; set; }

    public string MusteriAdi { get; set; }
    public string MusteriSoyadi { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public string ParaBirimiAdi { get; set; }

    public decimal ToplamTutar { get; set; }

    public string? SiparisDetayi { get; set; }

    public string SiparisDurumu { get; set; }

    //public virtual Musteri Musteri { get; set; } = null!;

    //public virtual ParaBirimi ParaBirimi { get; set; } = null!;

    //public virtual SiparisDurumu SiparisDurumu { get; set; } = null!;

    //public virtual ICollection<Tahsilat> Tahsilats { get; } = new List<Tahsilat>();
}
