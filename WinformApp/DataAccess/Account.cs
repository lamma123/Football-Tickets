using System;
using System.Collections.Generic;

namespace WinformApp.DataAccess;

public partial class Account
{
    public string Username { get; set; } = null!;

    public string? Password { get; set; }

    public int? Role { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
