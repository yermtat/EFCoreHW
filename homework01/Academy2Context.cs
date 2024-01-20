using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace homework01;

public class Academy2Context : DbContext
{

    public Academy2Context(DbContextOptions<Academy2Context> options)
        : base(options)
    {
    }

    public  DbSet<Curator> Curators { get; set; }

    public  DbSet<Department> Departments { get; set; }

    public  DbSet<Faculty> Faculties { get; set; }

    public  DbSet<Group> Groups { get; set; }

    public  DbSet<GroupsCurator> GroupsCurators { get; set; }

    public  DbSet<GroupsLecture> GroupsLectures { get; set; }

    public  DbSet<Lecture> Lectures { get; set; }

    public  DbSet<Subject> Subjects { get; set; }

    public  DbSet<Teacher> Teachers { get; set; }


}
