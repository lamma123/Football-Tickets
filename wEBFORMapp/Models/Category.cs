﻿using System;
using System.Collections.Generic;

namespace wEBFORMapp.Models;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<Ticket> Tickets { get; } = new List<Ticket>();
    public override string ToString()
    {
        return CategoryName;
    }
}
