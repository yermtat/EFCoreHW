using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace homework02_imdbAPI.Services
{
    public static class DownloadService
    {
        public static string DownloadJson(string url)
        {
            try
            {
                var client = new WebClient();
                client.Headers.Add("X-RapidAPI-Key", "6a5cdc4804msh0381aba3879aee8p1d32d1jsn871d8020b501");
                client.Headers.Add("X-RapidAPI-Host", "imdb8.p.rapidapi.com");

                var res = client.DownloadString(url);

                return res ?? throw new ArgumentNullException("Json is null");

            }
            catch
            {

                throw;
            }
        }
    }
}
