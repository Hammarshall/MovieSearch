using System;
namespace MovieSearch
{
    public class Movie
    {
        //public Uri Homepage { get; set; } // URL länk hur ska man göra då
        // står att det är en sträng på databas saken se skärm dump

        public int Id { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public string Overview { get; set; }

        //public Uri Poster_path { get; set; } // URL länk hur ska man göra då
        // står att det är en sträng på databas saken se skärm dump

        public string Release_date { get; set; }
        public int Runtime { get; set; }

        public double Vote_average { get; set; }
        // står att värdet är number i databasen??

        public Movie(/*homepage */ int id, string original_language, string original_title, string overview,/* poster_path */ string release_date, int runtime, double vote_average)// konstruktor
        {
            //this.Homepage = homepage;
            this.Id = id;
            this.Original_language = original_language;
            this.Original_title = original_title;
            this.Overview = overview;
            //this.Poster_path = poster_path;
            this.Release_date = release_date;
            this.Runtime = runtime;
            this.Vote_average = vote_average;
        }
    }
}
