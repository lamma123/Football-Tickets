using System;
using System.Collections.Generic;

namespace wEBFORMapp.Models;

public partial class ConfirmCode
{
    public string? Username { get; set; }

    public int? TicketId { get; set; }

    public string? Code { get; set; }

    public int Id { get; set; }

    public virtual Ticket? Ticket { get; set; }

    public virtual Account? UsernameNavigation { get; set; }
}
