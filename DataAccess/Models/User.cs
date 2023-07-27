using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class User
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public int? RoldId { get; set; }

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();
}
