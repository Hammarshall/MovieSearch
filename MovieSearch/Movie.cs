using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Console;

namespace MovieSearch
{
    public class Movie
    {
        public string Homepage { get; set; }
        public int Id { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public string Overview { get; set; }
        public string Poster_path { get; set; }
        public string Release_date { get; set; }
        public int Runtime { get; set; }
        public double Vote_average { get; set; }
    }
}
