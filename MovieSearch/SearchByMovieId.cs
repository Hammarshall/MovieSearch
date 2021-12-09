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
            
            Console.Write("Enter movie id: ");
            int id = int.Parse(Console.ReadLine());

            try
            {
                string uriId = $"https://api.themoviedb.org/3/movie/{id}?api_key=7a2b47ee7ece23d9547cabff80a87234";
                var response = await client.GetAsync(uriId);

                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();

                Movie movie = JsonConvert.DeserializeObject<Movie>(responseContent);
                

                Console.WriteLine("\nHomepage: {0}", movie.Homepage);
                //Console.WriteLine("\nId: ", movie.Id);
                Console.WriteLine("\nLanguage: {0}", movie.Original_language);
                Console.WriteLine("\nTitle: {0}", movie.Original_title);
                Console.WriteLine("\nOverview: {0}", movie.Overview);
                //Console.WriteLine(”\nPoster path: {0}”, movie.Poster_path);
                Console.WriteLine("\nRelease date: {0}", movie.Release_date);
                Console.WriteLine("\nRuntime: {0}", movie.Runtime);
                Console.WriteLine("\nVote average: {0}", movie.Vote_average);

                return movie;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            
        }

    }
}
