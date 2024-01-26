using homework02_imdbAPI.DataModels;
using homework02_imdbAPI.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_imdbAPI.Contexts;

public class ImdbBaseContext : DbContext
{
    public DbSet<Result> Results { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Principal> Principals { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Parenttitle> Parenttitles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=ImdbBase;Integrated Security=True;Trust Server Certificate=True;");
    }
}
