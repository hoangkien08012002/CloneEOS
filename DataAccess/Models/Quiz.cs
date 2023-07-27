using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Quiz
{
    public int Id { get; set; }

    public string? Question { get; set; }

    public string? Anwser { get; set; }

    public int? TypeId { get; set; }

    public virtual Type? Type { get; set; }
}
