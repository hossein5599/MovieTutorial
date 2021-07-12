using Serenity.Navigation;
using MyPages = MovieTutorial.MovieDB.Pages;

[assembly: NavigationLink(1000, "MovieDatabase/Movies", typeof(MyPages.MovieController), icon: "fa-video-camera")]
[assembly: NavigationLink(1001, "MovieDatabase/Genre", typeof(MyPages.GenreController), icon: null)]