using System;
using System.Collections.Generic;

namespace homework01;

public class Group
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Year { get; set; }

    public int DepartmentId { get; set; }

    public Department Department { get; set; }

    public ICollection<GroupsCurator> GroupsCurators { get; set; } = new List<GroupsCurator>();

    public ICollection<GroupsLecture> GroupsLectures { get; set; } = new List<GroupsLecture>();
}
