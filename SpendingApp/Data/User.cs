using System;
using System.Collections.Generic;

namespace SpendingApp.Data;

public partial class User
{
    public int UsersId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Spend> Spends { get; } = new List<Spend>();
}
