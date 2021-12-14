using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Console;

namespace MovieSearch
{
    public class SearchByTitle
    {
        private static HttpClient client = new HttpClient();

        public static async Task<Title> SearchTitle()
        {

            DotNetEnv.Env.TraversePath().Load();
            string key = Environment.GetEnvironmentVariable("APIKEY");
            string pic = Environment.GetEnvironmentVariable("STRINGPIC");

            Write("Enter movie title: ");
            try
            {
                string input = Console.ReadLine();

                string uriId = $"https://api.themoviedb.org/3/search/movie?api_key={key}&query={input}";
                var response = await client.GetAsync(uriId);

                response.EnsureSuccessStatusCode();
                var responseContent = await response.Content.ReadAsStringAsync();

                Title title = JsonConvert.DeserializeObject<Title>(responseContent);

                if (title.Results.Count < 0)
                {
                    WriteLine("no movie found");
                    WriteLine("\nPress any key to return to menu");
                    ReadKey(true);
                    Clear();
                    Startmenu.Menu();
                    foreach (var item in title.Results)
                    {
                        WriteLine("{0}:{1}", title.Results.IndexOf(item), item.Original_title);


                    }

                }
                

                WriteLine("\nSelect index: ");
                int id = Convert.ToInt32(Console.ReadLine());

                WriteLine("\nHomepage: {0}", title.Results[id].Homepage);
                WriteLine("\nMovie id: {0}", title.Results[id].Id);
                WriteLine("\nLanguage: {0}", title.Results[id].Original_language);
                WriteLine("\nTitle: {0}", title.Results[id].Original_title);
                WriteLine("\nOverview: {0}", title.Results[id].Overview);
                WriteLine("\nPoster path: {0}", pic + title.Results[id].Poster_path);
                WriteLine("\nRelease date: {0}", title.Results[id].Release_date);
                WriteLine("\nRuntime in minutes: {0}", title.Results[id].Runtime);
                WriteLine("\nVote average: {0}", title.Results[id].Vote_average);


                WriteLine("\nPress any key to return to menu");
                ReadKey(true);
                Clear();
                Startmenu.Menu();

                return title;
            }
            catch(Exception e)
            {
                WriteLine(e.Message);
                WriteLine("\nPress any key to return to menu");
                ReadKey(true);
                Clear();
                Startmenu.Menu();

                return null;
            }
            
        }
    }
}
