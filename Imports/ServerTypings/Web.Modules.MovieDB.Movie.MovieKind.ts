namespace MovieTutorial.Web.Modules.MovieDB.Movie {
    export enum MovieKind {
        Film = 1,
        TvSeries = 2,
        MiniSeries = 3
    }
    Serenity.Decorators.registerEnumType(MovieKind, 'MovieTutorial.Web.Modules.MovieDB.Movie.MovieKind', 'MovieDB.MovieKind');
}
