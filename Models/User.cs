using System;
using System.Collections.Generic;

namespace RestoSMK.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? Status { get; set; }

    public string Nama { get; set; } = null!;

    public string NoHp { get; set; } = null!;

    public string? Alamat { get; set; }

    public DateTime? CreateAt { get; set; }

    public virtual ICollection<Transaksi> Transaksis { get; set; } = new List<Transaksi>();
}
