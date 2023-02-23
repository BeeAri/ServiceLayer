using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class Tahsilat
{
    public int TahsilatId { get; set; }

    public int MusteriId { get; set; }

    public int ParaBirimiId { get; set; }

    public decimal Tutar { get; set; }

    public int SiparisId { get; set; }

    public int TahsilatTipiId { get; set; }

    public DateTime? TahsilatTarihi { get; set; }

    public virtual Musteri Musteri { get; set; } = null!;

    public virtual ParaBirimi ParaBirimi { get; set; } = null!;

    public virtual Sipari Siparis { get; set; } = null!;

    public virtual TahsilatTipi TahsilatTipi { get; set; } = null!;
}
