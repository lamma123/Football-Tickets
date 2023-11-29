using System;
using System.Collections.Generic;

namespace wEBFORMapp.Models;

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

    public virtual ICollection<ConfirmCode> ConfirmCodes { get; } = new List<ConfirmCode>();

    public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();

  
}
