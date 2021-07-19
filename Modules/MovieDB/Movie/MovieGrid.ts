

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

        //protected getQuickFilters(): Serenity.QuickFilter<Serenity.Widget<any>, any>[] {
        //    //Gets the Filters defined in the Columns or in parent grids.
        //    let filters = super.getQuickFilters();

        //    //Insert a new checkbox filter for seeing if the column DeletedOn (date) is not Null
        //    //Show or hide deleted items option
        //    filters.push({
        //        field: EntityRow.Fields.DeletedOn,
        //        type: Serenity.BooleanEditor,
        //        title: "Show Deleted",
        //        handler: h => {
        //            h.active = !!h.value;
        //            if (h.active) {
        //                h.request.Criteria = Serenity.Criteria.and(h.request.Criteria,
        //                    ['is not null', [EntityRow.Fields.DeletedOn]]);
        //            } else {
        //                h.request.Criteria = Serenity.Criteria.and(h.request.Criteria,
        //                    ['is null', [EntityRow.Fields.DeletedOn]]);
        //            }
        //        }
        //    });

        //    return filters;
        //}

        
//let filters = super.getQuickFilters();
//    import fld = GeolocationRow.Fields;

//    let filter = Q.tryFirst(filters, x => x.field == fld.IsActive);

//    if (filter != null) {
//        filter.handler = h => {
//            if (h.active) {
//                h.request.Criteria = Serenity.Criteria.and(
//                    h.request.Criteria,
//                    [[fld.IsActive], '=', true])
//            }
//        }
//    } else {
//        filters.push({
//            field: fld.IsActive,
//            type: Serenity.BooleanEditor,
//            handler: h => {
//                if (h.active) {
//                    h.request.Criteria = Serenity.Criteria.and(
//                        h.request.Criteria,
//                        [[fld.IsActive], '=', true])
//                }
//            }
//        })
//    }


        protected  onViewSubmit() {

            if (!super.onViewSubmit())
                return false;
            let request = this.view.params as Serenity.ListRequest;// view.Params;
            //Q.notifyInfo("Request:" + this.view.params);

            //this.StartDate = $('#Tag1').find('input[name="StartDate"]').val();
            //this.EndDate = $('#Tag1').find('input[name="EndDate"]').val();
            //this.Progid = $('#Tag1').find('input[name="Progid"]').val();
            //this.LocationId = $('#Tag1').find('input[name="LocationId"]').val();
            //var search: any[] = [];


            ////this.view.params = request;
            //Q.notifyInfo("Program" + this.Progid);

            //Q.notifyInfo("super.onViewSubmit():" + super.onViewSubmit());

           // request.ExcludeColumns = new List<string> { "Notes" }
            return true;

        }
    }
}