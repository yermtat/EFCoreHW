using System;
using System.Collections.Generic;

namespace homework01;

public class GroupsCurator
{
    public int Id { get; set; }

    public int CuratorId { get; set; }

    public int GroupId { get; set; }

    public Curator Curator { get; set; }

    public Group Group { get; set; }
}
