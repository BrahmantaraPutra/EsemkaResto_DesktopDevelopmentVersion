using System;
using System.Collections.Generic;

namespace RestoSMK.Models;

public partial class Meja
{
    public int MejaId { get; set; }

    public int NoMeja { get; set; }

    public int? Kapasitas { get; set; }

    public string? Status { get; set; }

    public DateTime? CreateAt { get; set; }

    public virtual ICollection<Transaksi> Transaksis { get; set; } = new List<Transaksi>();
}
