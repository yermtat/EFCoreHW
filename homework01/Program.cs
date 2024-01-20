using homework01;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Runtime.Serialization.Json;

var configBuilder = new ConfigurationBuilder();
configBuilder.AddJsonFile("appSettings.json");
var config = configBuilder.Build();

var connString = config.GetConnectionString("default");

var dbContextOptionsBuilder = new DbContextOptionsBuilder<Academy2Context>();

var options = dbContextOptionsBuilder.UseSqlServer(connString).Options;

using var context = new Academy2Context(options);

var teachers = context.Teachers;

foreach (var teacher in teachers)
{
    Console.WriteLine($"{teacher.Name} {teacher.Surname} - {teacher.Salary}");
}

Console.WriteLine();
var teachers2 = context.Teachers.Where(t => t.Salary < 1000);

foreach (var teacher in teachers2)
{
    Console.WriteLine($"{teacher.Name} {teacher.Surname} - {teacher.Salary}");
}


