using System;
using System.Collections.Generic;

namespace homework01;

public class GroupsLecture
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int LectureId { get; set; }

    public Group Group { get; set; }

    public Lecture Lecture { get; set; }
}
