﻿using System;
using System.Collections.Generic;

namespace ServiceLayer.Models;

public partial class Sehir
{
    public int SehirId { get; set; }

    public string SehirAdi { get; set; } = null!;

    public virtual Musteri? Musteri { get; set; }
}
