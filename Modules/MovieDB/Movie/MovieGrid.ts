
namespace MovieTutorial.MovieDB {

    @Serenity.Decorators.registerClass()
    export class MovieGrid extends Serenity.EntityGrid<MovieRow, any> {
        protected getColumnsKey() { return 'MovieDB.Movie'; }
        protected getDialogType() { return MovieDialog; }
        protected getIdProperty() { return MovieRow.idProperty; }
        protected getInsertPermission() { return MovieRow.insertPermission; }
        protected getLocalTextPrefix() { return MovieRow.localTextPrefix; }
        protected getService() { return MovieService.baseUrl; }

        constructor(container: JQuery) {
            super(container);

        }
        private getTextService(s): string {

            if (s === 'all') {
                return Q.text("Db.GeneralMessages.All");
            }
            return Q.text("Db." +
                MovieRow.localTextPrefix + "." + s).toLowerCase();
        }

        protected getQuickSearchFields():
            Serenity.QuickSearchField[] {

            let txt = (s) => this.getTextService(s);

            return [
                { name: "", title: txt("all") },
                { name: MovieRow.Fields.Description, title: txt(MovieRow.Fields.Description) },
                { name: MovieRow.Fields.Storyline, title: txt(MovieRow.Fields.Storyline) },
                { name: MovieRow.Fields.Year , title: txt(MovieRow.Fields.Year) }
            ];

         
            //return [
            //    { name: "", title: "all" },
            //    { name: "Description", title: "description" },
            //    { name: "Storyline", title: "storyline" },
            //    { name: "Year", title: "year" }
            //];
        }

        
    }
}