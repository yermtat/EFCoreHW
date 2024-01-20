using System;
using System.Collections.Generic;

namespace homework01;

public class Lecture
{
    public int Id { get; set; }

    public string LectureRoom { get; set; }

    public int SubjectId { get; set; }

    public int TeacherId { get; set; }

    public ICollection<GroupsLecture> GroupsLectures { get; set; } = new List<GroupsLecture>();

    public Subject Subject { get; set; }

    public Teacher Teacher { get; set; }
}
