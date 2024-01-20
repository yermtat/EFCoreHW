using System;
using System.Collections.Generic;

namespace homework01;

public class Department
{
    public int Id { get; set; }

    public decimal Financing { get; set; }

    public string Name { get; set; }

    public int FacultyId { get; set; }

    public Faculty Faculty { get; set; }

    public ICollection<Group> Groups { get; set; } = new List<Group>();
}
