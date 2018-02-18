using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public static class IGDB
    {
                 
        static string QueryBuild(string[] methods, string[] parameters)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string m in methods)
            {
                sb.Append(m);
            };
            return string.Empty;
        }      
        static string GetJson(string query)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("https://api-2445582011268.apicast.io/"+query);
            req.Accept = "application/json";
            req.Headers.Add("user-key", "abff7a89d6e5246d4b15f48056170927");
            string json = string.Empty;       
            var httpResponse = (HttpWebResponse)req.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                json = streamReader.ReadToEnd();
            }
            return json;
        }
        public static List<Game> GetGames(string search)
        {
            string query = "games/?search=" + search + "&fields=*";//id,name,summary";
            string json = GetJson(query);

           List<Game> games = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Game>>(json);
            if (games.Count>0)
            {
                List<int> genreIds = new List<int>();                
                //rozbicie id gatunkó by jendokrotnie wywołać getGenres
                foreach(Game g in games)
                {
                    List<Genre> tmpGenres = new List<Genre>();
                    genreIds.AddRange(g.genres);
                    foreach (int gid in g.genres)
                    {
                        tmpGenres.Add(new Genre { id = gid, name = string.Empty });
                    }
                    g.genresObj = tmpGenres.ToArray();
                }

                var uniqueGenreIds = genreIds.Distinct();

                Genre[] allGenres = getGenres(uniqueGenreIds.ToArray());

                foreach(Game g in games)
                {
                    foreach(Genre gn in g.genresObj)
                    {
                        gn.name = allGenres.FirstOrDefault(x => x.id == gn.id).name;
                    }             
                }
            }
           return games;
        }
        private static Genre[] getGenres(int[] ids)
        {
            
            //string[] idStrings = ids.Select(x => x.ToString()).ToArray();
            string parameters = string.Join(",", ids);
            string query = "genres/" + parameters;
            string json = GetJson(query);
            Genre[] genres = Newtonsoft.Json.JsonConvert.DeserializeObject<Genre[]>(json);
            return genres;
        }

        
    }
}
