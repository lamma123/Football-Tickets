using System;
using System.Collections.Generic;

namespace wEBFORMapp.Models;

public partial class Account
{
    public string Username { get; set; } = null!;

    public string? Password { get; set; }

    public int? Role { get; set; }

    public virtual ICollection<ConfirmCode> ConfirmCodes { get; } = new List<ConfirmCode>();

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
