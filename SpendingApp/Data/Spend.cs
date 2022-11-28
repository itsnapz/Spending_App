using System;
using System.Collections.Generic;

namespace SpendingApp.Data;

public partial class Spend
{
    public int SpendId { get; set; }

    public string? Name { get; set; }

    public int? Price { get; set; }

    public int? UsersId { get; set; }

    public DateTime? Dateofaddition { get; set; }

    public bool? Paid { get; set; }

    public virtual User? Users { get; set; }
}
