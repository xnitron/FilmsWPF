using System;
using Newtonsoft.Json;

namespace FilmsWPF.Model
{
    public class FilmModel
    {
        public int id { get; set; }
        [JsonProperty("poster_path")]
        public string DisplayImage { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("vote_average")]
        public double Vote { get; set; }
        [JsonProperty("overview")]
        public string OverView { get; set; }
        [JsonProperty("release_date")]
        public DateTime ReleaseDate{ get; set; }
        
    }
}
