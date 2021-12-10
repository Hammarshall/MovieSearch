using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Console;

namespace MovieSearch
{
    public class SearchByMovieId
    {
        private static HttpClient client = new HttpClient();

        public static async Task<Movie> SearchById()
        {
            DotNetEnv.Env.TraversePath().Load();
            string key = Environment.GetEnvironmentVariable("APIKEY");
            string pic = Environment.GetEnvironmentVariable("STRINGPIC");

            Clear();

            Write("Enter ID for movie: ");
            //int id = int.Parse(Console.ReadLine());

            try
            {
                int id = int.Parse(Console.ReadLine()); // om ngn skriver bokstäver så krashar ej allt

                string uriId = $"https://api.themoviedb.org/3/movie/{id}?api_key={key}";
                var response = await client.GetAsync(uriId);

                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();

                Movie movie = JsonConvert.DeserializeObject<Movie>(responseContent);

                WriteLine("\nHomepage: {0}", movie.Homepage);
                WriteLine("\nMovie id: {0}", movie.Id);
                WriteLine("\nLanguage: {0}", movie.Original_language);
                WriteLine("\nTitle: {0}", movie.Original_title);
                WriteLine("\nOverview: {0}", movie.Overview);
                WriteLine("\nPoster path: " + pic + movie.Poster_path);
                WriteLine("\nRelease date: {0}", movie.Release_date);
                WriteLine("\nRuntime in minutes: {0}", movie.Runtime);
                WriteLine("\nVote average: {0}", movie.Vote_average);

                WriteLine("\nPress any key to return to menu");
                ReadKey();
                Clear();
                Startmenu.Menu();
                
                return movie;
                

            }
            catch (Exception e)
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
