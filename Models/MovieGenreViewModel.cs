using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie1.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies;
        public SelectList Genres;
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
        public string DateSort { get; set; }
        public string MovieSort { get; set; }
        public string CurrentSort { get; set; }
        public string CurrentFilter { get; set; }
    }
}