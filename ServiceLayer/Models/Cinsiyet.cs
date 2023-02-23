using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class Cinsiyet
{
    public int CinsiyetId { get; set; }

    public string CinsiyetAdi { get; set; } = null!;

    public virtual ICollection<Musteri> Musteris { get; } = new List<Musteri>();
}
