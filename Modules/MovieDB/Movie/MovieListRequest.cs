using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTutorial.MovieDB
{
    public class MovieListRequest : ListRequest
    {
        public List<int> Genres { get; set; }

    }
}
