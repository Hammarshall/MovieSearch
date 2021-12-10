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

            Clear();

            Write("Enter title for movie: ");
            string input = Console.ReadLine();

            try//EV KOLLA gör om till if sats (search.Results.count >0))
            {
                string uriId = $"https://api.themoviedb.org/3/search/movie?api_key={key}&query={input}";
                var response = await client.GetAsync(uriId);

                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();

                Title title = JsonConvert.DeserializeObject<Title>(responseContent);

                foreach (var item in title.Results)
                {
                    WriteLine($"{item.Original_title}");//Osäker om de kmr ut filmer, 
                }

                WriteLine("\nPress any key to return to menu");
                ReadKey();
                Clear();
                Startmenu.Menu();

                return title;

            }
            catch (Exception e)//Kommer ej ner här om ingen film matchar, KOLLA
            {
                WriteLine(e.Message);

                WriteLine("\nPress any key to return to menu");
                ReadKey();
                Clear();
                Startmenu.Menu();

                return null;
            }
        }

    }
}
