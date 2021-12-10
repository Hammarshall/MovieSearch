using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
//using static System.Console;

namespace MovieSearch
{
    public class SearchByTitle
    {
        private static HttpClient client = new HttpClient();

        public static async Task<Title> SearchTitle()
        {
            string pic = @"https://image.tmdb.org/t/p/w500/";

            DotNetEnv.Env.TraversePath().Load();
            string key = Environment.GetEnvironmentVariable("APIKEY");

            Console.Write("Enter title for movie: ");
            string input = Console.ReadLine();

            try // eventuell kolla på det (gör om t if sats ist (search.Results.count >0))
            {
                string uriId = $"https://api.themoviedb.org/3/search/movie?api_key={key}&query={input}";
                var response = await client.GetAsync(uriId);

                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();

                Title title = JsonConvert.DeserializeObject<Title>(responseContent);

                foreach (var item in title.Results)
                {
                    Console.WriteLine($"{item.Original_title}");
                }

                Console.WriteLine("Press any key to return to menu");
                Console.ReadKey(true);
                Console.Clear();
                Startmenu.Menu();

                return title;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to return to menu");
                Console.ReadKey(true);
                Console.Clear();
                Startmenu.Menu();
                return null;
            }
        }

    }
}
