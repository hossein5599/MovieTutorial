using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using MovieTutorial.Web.Modules.MovieDB.Movie;

namespace MovieTutorial.MovieDB.Forms
{
    [FormScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow), CheckNames = true)]
    public class MovieForm
    {
        public String Title { get; set; }
        [TextAreaEditor(Rows = 2)]
        public String Description { get; set; }
        [TextAreaEditor(Rows = 5)]

        public String Storyline { get; set; }
        public Int32 Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Int32 Runtime { get; set; }


        public Int32 GenreId { get; set; }

        public MovieKind Kind { get; set; }



    }
}