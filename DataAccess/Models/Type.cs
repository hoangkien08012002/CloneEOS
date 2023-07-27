using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Type
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public int Time { get; set; }

    public virtual ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();

    public virtual ICollection<Result> Results { get; set; } = new List<Result>();
}
