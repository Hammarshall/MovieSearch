using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Console;

namespace MovieSearch
{
    public class SearchByMovieId
    {
        public static HttpClient client = new HttpClient();

        public static async Task<Movie> SearchById()
        {
            int id = 0;

            Console.Write("Enter movie id: ");
            id = int.Parse(Console.ReadLine());

            try
            {
                string uriId = $"https://api.themoviedb.org/3/movie/{id}?api_key=7a2b47ee7ece23d9547cabff80a87234";
                var response = await client.GetAsync(uriId);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();

                Movie thismovie = JsonConvert.DeserializeObject<Movie>(responseContent);

                return thismovie;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
