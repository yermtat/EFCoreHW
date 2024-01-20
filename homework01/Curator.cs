using System;
using System.Collections.Generic;

namespace homework01;

public class Curator
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Surname { get; set; }

    public ICollection<GroupsCurator> GroupsCurators { get; set; } = new List<GroupsCurator>();
}
