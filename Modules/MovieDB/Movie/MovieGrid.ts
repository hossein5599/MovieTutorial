

namespace MovieTutorial.MovieDB {

    @Serenity.Decorators.registerClass()
    export class MovieGrid extends Serenity.EntityGrid<MovieRow, any> {
        protected getColumnsKey() { return 'MovieDB.Movie'; }
        protected getDialogType() { return MovieDialog; }
        protected getIdProperty() { return MovieRow.idProperty; }
        protected getInsertPermission() { return MovieRow.insertPermission; }
        protected getLocalTextPrefix() { return MovieRow.localTextPrefix; }
        protected getService() { return MovieService.baseUrl; }

        //constructor(container: JQuery) {
        //    super(container);

        //}
        //private getTextService(s): string {

        //    if (s === 'all') {
        //        return Q.text("Db.GeneralMessages.All");
        //    }
        //    return Q.text("Db." +
        //        MovieRow.localTextPrefix + "." + s).toLowerCase();
        //}

        //protected getQuickSearchFields():
        //    Serenity.QuickSearchField[] {

        //    let txt = (s) => this.getTextService(s);

        //    return [
        //        { name: "", title: txt("all") },
        //        { name: MovieRow.Fields.Description, title: txt(MovieRow.Fields.Description) },
        //        { name: MovieRow.Fields.Storyline, title: txt(MovieRow.Fields.Storyline) },
        //        { name: MovieRow.Fields.Year , title: txt(MovieRow.Fields.Year) }
        //    ];

         
        //    //return [
        //    //    { name: "", title: "all" },
        //    //    { name: "Description", title: "description" },
        //    //    { name: "Storyline", title: "storyline" },
        //    //    { name: "Year", title: "year" }
        //    //];
        //}
        //...
        //protected getQuickFilters() {
        //    let items = super.getQuickFilters();

        //    var genreListFilter = Q.first(items, x =>
        //        x.field == MovieRow.Fields.GenreList);

        //    genreListFilter.handler = h => {
        //        var request = (h.request as MovieDB. MovieListRequest);
        //        var values = (h.widget as Serenity.LookupEditor).values;
        //        request.Genres = values.map(x => parseInt(x, 10));
        //        h.handled = true;
        //    };

        //    return items;
        //}
        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            let fld = MovieDB.MovieRow;
            let txt = (s) => Q.text("Db." + MovieRow.localTextPrefix + "." + s).toLowerCase();
            return [
                { name: "", title: "all" },
                { name: MovieDB.MovieRow.Fields.Description, title: txt(MovieDB.MovieRow.Fields.Description) },
                { name: MovieDB.MovieRow.Fields.Storyline, title: txt(MovieDB.MovieRow.Fields.Storyline) },
                { name: MovieDB.MovieRow.Fields.Year, title: txt(MovieDB.MovieRow.Fields.Year) }
            ];
        }

        protected getQuickFilters() {
            let items = super.getQuickFilters();

           // debugger;
            
            var genreListFilter = Q.first(items, x =>
                x.field == MovieRow.Fields.GenreList);

            genreListFilter.handler = h => {
                var request = (h.request as MovieListRequest);
                var values = (h.widget as Serenity.LookupEditor).values;
                request.Genres = values.map(x => parseInt(x, 10));
                h.handled = true;
            };

            return items;
        }
    }
}