using System;
using System.Collections.Generic;

namespace homework01;

public class Subject
{
    public int Id { get; set; }

    public string Name { get; set; }

    public ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();
}
