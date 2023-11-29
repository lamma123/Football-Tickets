using System;
using System.Collections.Generic;

namespace WinformApp.DataAccess;

public partial class Order
{
    public int OrderId { get; set; }

    public string? Username { get; set; }
    public string? Code { get; set; }    
    public DateTime? Orderdate { get; set; }

    public virtual Account? UsernameNavigation { get; set; }
}
