using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplesConsumoAPI
{
    public class MovieModel
    {
        public string Title { get; set; }
        public string Plot { get; set; }
        public string Year { get; set; }
        public string Actors { get; set; }
        public string Genre { get; set; }
        public string Poster { get; set; }
    }
    public class SearchResponseModel
    {
        public List<MovieBySearch> Search { get; set; }
        public int totalResults { get; set; }
        public bool Response { get; set; }
    }
    public class MovieBySearch
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }
    }
}
