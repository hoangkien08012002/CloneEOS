using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Result
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? TypeId { get; set; }

    public double? Grade { get; set; }

    public virtual Type? Type { get; set; }

    public virtual User? User { get; set; }
}
