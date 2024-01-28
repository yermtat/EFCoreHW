using homework02_imdbAPI.Contexts;
using homework02_imdbAPI.DataModels;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_imdbAPI.Services;

public static class DataSavingService
{
    public static ImdbBaseContext Context { get; set; } = new();

    public static void SaveData(Result result)
    {
        Context.Results.Add(result);

        Context.SaveChanges();

    }
}
