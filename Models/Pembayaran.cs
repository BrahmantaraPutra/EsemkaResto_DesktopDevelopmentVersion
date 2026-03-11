using System;
using System.Collections.Generic;

namespace RestoSMK.Models;

public partial class Pembayaran
{
    public int Id { get; set; }

    public int TransaksiId { get; set; }

    public string? JeniPembayaran { get; set; }

    public decimal? Nominal { get; set; }

    public string? MetodeBayar { get; set; }

    public string? StatusBayar { get; set; }

    public string? ExternalId { get; set; }

    public DateTime? CreateAt { get; set; }

    public virtual Transaksi Transaksi { get; set; } = null!;
}
