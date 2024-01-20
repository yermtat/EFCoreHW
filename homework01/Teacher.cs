using System;
using System.Collections.Generic;

namespace homework01;

public class Teacher
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal Salary { get; set; }

    public string Surname { get; set; }

    public ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();
}
