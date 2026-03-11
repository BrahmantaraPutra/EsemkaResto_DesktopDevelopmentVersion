using System;
using System.Collections.Generic;

namespace RestoSMK.Models;

public partial class Transaksi
{
    public int TransaksiId { get; set; }

    public int PelangganId { get; set; }

    public int MejaId { get; set; }

    public string KodeBooking { get; set; } = null!;

    public string? StatusTransaksi { get; set; }

    public decimal? TotalTagihan { get; set; }

    public DateTime? CreateAt { get; set; }

    public virtual ICollection<DetailTransaksi> DetailTransaksis { get; set; } = new List<DetailTransaksi>();

    public virtual Meja Meja { get; set; } = null!;

    public virtual User Pelanggan { get; set; } = null!;

    public virtual ICollection<Pembayaran> Pembayarans { get; set; } = new List<Pembayaran>();
}
