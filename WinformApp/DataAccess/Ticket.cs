using System;
using System.Collections.Generic;

namespace WinformApp.DataAccess;

public partial class Ticket
{
    public int TicketId { get; set; }

    public string? TenTranDau { get; set; }

    public DateTime? Time { get; set; }

    public decimal? Price { get; set; }

    public int? CategoryId { get; set; }

    public string? Description { get; set; }

    public int? Quantity { get; set; }

    public virtual Category? Category { get; set; }
}
