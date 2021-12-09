using System;
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

        /* public Movie(/*homepage int id, string original_language, string original_title, string overview, string poster_path, string release_date, int runtime, double vote_average)// konstruktor
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
        */
    }
}
