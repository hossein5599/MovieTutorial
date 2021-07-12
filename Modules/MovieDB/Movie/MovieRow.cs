using MovieTutorial.Web.Modules.MovieDB.Movie;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;
using System.IO;

namespace MovieTutorial.MovieDB.Entities
{
    [ConnectionKey("Default"), Module("MovieDB"), TableName("[mov].[Movies]")]
    [DisplayName("Movies"), InstanceName("Movie")]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class MovieRow : Row<MovieRow.RowFields>, IIdRow, INameRow
    {
        [DisplayName("Movie Id"), Identity, IdProperty]
        public Int32? MovieId
        {
            get => fields.MovieId[this];
            set => fields.MovieId[this] = value;
        }
       //[LinkingSetRelation]

        [DisplayName("Title"), Size(200), NotNull, QuickSearch, NameProperty]
        public String Title
        {
            get => fields.Title[this];
            set => fields.Title[this] = value;
        }

        [DisplayName("Description"), Size(1000), NotNull, QuickSearch]
        public String Description
        {
            get => fields.Description[this];
            set => fields.Description[this] = value;
        }

        [DisplayName("Storyline"), NotNull, QuickSearch]
        public String Storyline
        {
            get => fields.Storyline[this];
            set => fields.Storyline[this] = value;
        }

        [DisplayName("Year"), NotNull]
        public Int32? Year
        {
            get => fields.Year[this];
            set => fields.Year[this] = value;
        }

        [DisplayName("Release Date"), NotNull]
        public DateTime? ReleaseDate
        {
            get => fields.ReleaseDate[this];
            set => fields.ReleaseDate[this] = value;
        }

        [DisplayName("Runtime (mins)"), NotNull]
        public Int32? Runtime
        {
            get => fields.Runtime[this];
            set => fields.Runtime[this] = value;
        }

        [DisplayName("Kind"), NotNull, DefaultValue(MovieKind.Film)]
        public MovieKind? Kind
        {
            get { return (MovieKind?)fields.Kind[this]; }
            set { fields.Kind[this] = (Int32?)value; }
        }

        [DisplayName("Genre"), ForeignKey("[mov].Genre", "GenreId"), LeftJoin("g")]
        //[LookupEditor("MovieDB.Genre")]
        [LookupEditor(typeof(GenreRow), InplaceAdd = true)]
        public Int32? GenreId
        {
            get { return fields.GenreId[this]; }
            set { fields.GenreId[this] = value; }
        }

        [DisplayName("Genre"), Expression("g.Name")]
        public String GenreName
        {
            get { return Fields.GenreName[this]; }
            set { Fields.GenreName[this] = value; }
        }

        public MovieRow()
            : base()
        {
        }

        public MovieRow(RowFields fields)
            : base(fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MovieId;
            public StringField Title;
            public StringField Description;
            public StringField Storyline;
            public Int32Field Year;
            public DateTimeField ReleaseDate;
            public Int32Field Runtime;
            public Int32Field Kind;
            public Int32Field GenreId;
            public StringField GenreName;

        }
    }
}
