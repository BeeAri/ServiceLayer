using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class VTahsilat
{
    public int TahsilatId { get; set; }

    public string MusteriAdi { get; set; }
    public string MusteriSoyadi { get; set; }

    public string ParaBirimiAdi { get; set; }

    public decimal Tutar { get; set; }

    public int SiparisId { get; set; }
    public string SiparisDetayi { get; set; }

    public string TahsilatTipi { get; set; }

    public DateTime? TahsilatTarihi { get; set; }

    //public virtual Musteri Musteri { get; set; } = null!;

    //public virtual ParaBirimi ParaBirimi { get; set; } = null!;

    //public virtual Sipari Siparis { get; set; } = null!;

    //public virtual TahsilatTipi TahsilatTipi { get; set; } = null!;
}
