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
    
    private static string str = "egwgw";
    private static int count = 0;

    public static void SaveData(Result result)
    {
        Context.Results.Add(result);
        Context.Images.Add(result.Image);

        foreach (var item in result.Principals)
        {
            Context.Principals.Add(item);        
        }

        foreach (var item in result.Principals)
        {
            foreach (var item2 in item.Roles)
            {
                Context.Roles.Add(item2);
            }
        }

        if (result.ParentTitle == null)
        {
            result.ParentTitle = new Parenttitle();
            result.ParentTitle.Id = str;
            for (int i = 0; i < count; i++)
            {
                result.ParentTitle.Id+= str;
            }
        }
        Context.Parenttitles.Add(result.ParentTitle);

        Context.SaveChanges();
    }
}
