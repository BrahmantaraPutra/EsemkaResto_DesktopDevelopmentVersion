using System;
using System.Collections.Generic;

namespace RestoSMK.Models;

public partial class Menu
{
    public int MenuId { get; set; }

    public string NamaMenu { get; set; } = null!;

    public decimal Harga { get; set; }

    public int? Stock { get; set; }

    public byte[]? Foto { get; set; }

    public DateTime? CreateAt { get; set; }

    public virtual ICollection<DetailTransaksi> DetailTransaksis { get; set; } = new List<DetailTransaksi>();
}
