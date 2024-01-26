using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_imdbAPI.Services;

public static class ConnectionService
{
    public static ConfigurationBuilder ConfigBuilder { get; set; } = new ConfigurationBuilder();
    public static string GetConnection()
    {
        ConfigBuilder.AddJsonFile("appSettings.json");
        return ConfigBuilder.Build().GetConnectionString("Default");
    }
}
