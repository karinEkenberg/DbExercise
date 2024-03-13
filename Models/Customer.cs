using System;
using System.Collections.Generic;

namespace DbExercise.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? Name { get; set; }

    public string? Adress { get; set; }

    public int? Phone { get; set; }

    public string? State { get; set; }
}
