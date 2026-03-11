using System;
using System.Collections.Generic;

namespace RestoSMK.Models;

public partial class DetailTransaksi
{
    public int Id { get; set; }

    public int TransaksiId { get; set; }

    public int MenuId { get; set; }

    public int Qty { get; set; }

    public decimal? Harga { get; set; }

    public DateTime? CreateAt { get; set; }

    public virtual Menu Menu { get; set; } = null!;

    public virtual Transaksi Transaksi { get; set; } = null!;
}
