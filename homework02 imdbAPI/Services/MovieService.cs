using homework02_imdbAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework02_imdbAPI.Services;

public static class MovieService
{
    public static Rootobject GetMovies(string movieTitle)
    {
        string url = $"https://imdb8.p.rapidapi.com/title/find?q={movieTitle}";

        try
        {
            string json = DownloadService.DownloadJson(url);
            return DeserializeService.DeserializeJson<Rootobject>(json) ?? throw new NullReferenceException();

        }
        catch
        {
            throw;
        }


    }
}
