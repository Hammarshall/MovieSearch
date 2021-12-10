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

            Console.Write("Enter title for movie: ");
            string input = Console.ReadLine();

            try // gör om t if sats ist (search.Results.count >0)
            {
                string uriId = $"https://api.themoviedb.org/3/search/movie?api_key=7a2b47ee7ece23d9547cabff80a87234&query={input}";
                var response = await client.GetAsync(uriId);

                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();

                Title title = JsonConvert.DeserializeObject<Title>(responseContent);

                foreach (var item in title.Results)
                {
                    Console.WriteLine($"{item.Original_title}");
                }

                return title;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }
}
