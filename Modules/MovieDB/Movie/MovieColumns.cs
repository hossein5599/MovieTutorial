using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;

namespace MovieTutorial.MovieDB.Columns
{
    [ColumnsScript("MovieDB.Movie")]
    [BasedOnRow(typeof(Entities.MovieRow), CheckNames = true)]
    public class MovieColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 MovieId { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Storyline { get; set; }
        [EditLink , QuickFilter]
        
        public Int32 Year { get; set; }
        public DateTime ReleaseDate { get; set; }
        [ Width(400), AlignRight]
        public Int32 Runtime { get; set; }
        [Width(100), QuickFilter]
        public Int32 GenreName { get; set; }

    }
}