using System;
using System.Collections.Generic;

namespace homework01;

public class Faculty
{
    public int Id { get; set; }

    public decimal Financing { get; set; }

    public string Name { get; set; }

    public ICollection<Department> Departments { get; set; } = new List<Department>();
}
