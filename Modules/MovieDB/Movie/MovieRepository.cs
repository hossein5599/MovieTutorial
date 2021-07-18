using MovieTutorial.Web.Modules.MovieDB.Movie;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System;
using System.Collections.Generic;
using System.Data;
using MyRow = MovieTutorial.MovieDB.Entities.MovieRow;

namespace MovieTutorial.MovieDB.Repositories
{
    public class MovieRepository : BaseRepository
    {
        private static MyRow.RowFields Fld => MyRow.Fields;

        public MovieRepository(IRequestContext context)
            : base(context)
        {
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler(Context).Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler(Context).Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler(Context).Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler(Context).Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {


            var test = new MyListHandler(Context).Process(connection, request);
          //  return new MyListHandler(Context).Process(connection, request);

            return test;
        }

        private class MySaveHandler : SaveRequestHandler<MyRow>
        {
            public MySaveHandler(IRequestContext context)
                : base(context)
            {

            }
            protected override void ValidateRequest()
            {
                base.ValidateRequest();
                //Connection.

                //if (Row.Title == "+19")
                //    throw new ValidationError("لطفا بی تربیت نباشید");
                    
                    
                    //  Row.CreateDate = DateTime.Now;
                if (Row.Title != "اکبر")
                {
                   // throw new ValidationError("نمیشه اکبر باشه")
                }


                //var movieRows = Connection.List<MovieRow>();


            }

            protected override void AfterSave()
            {
                base.AfterSave();

                

            }

        }

        private class MyDeleteHandler : DeleteRequestHandler<MyRow>
        {
            public MyDeleteHandler(IRequestContext context)
                : base(context)
            {
            }

        }

        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow>
        {
            public MyRetrieveHandler(IRequestContext context)
                : base(context)
            {
            }
        }

        private class MyListHandler : ListRequestHandler<MyRow , ListRequest>
        {
            public MyListHandler(IRequestContext context)
                : base(context)
            { }


            protected override void PrepareQuery(SqlQuery query)
            {
                Request.Take = 10;

                base.PrepareQuery(query);
            }

            
            

            protected override void ApplyFilters(SqlQuery query)
            {

                Request.Take = 10;

                base.ApplyFilters(query);

                //if (!Request.Genres.IsEmptyOrNull())
                //{
                    var mg = Entities.MovieGenresRow.Fields.As("mg");
               // Request.Sort
                var list = new List<int>()
                {
                    1,2,3,4,5,6
                };

               // Request.Criteria.IsNull
                    query.Where(Criteria.Exists(
                        query.SubQuery()
                            .From(mg)
                            .Select("1")
                            .Where(

                                mg.MovieId == Fld.MovieId &&
                                mg.GenreId.In(list))
                            .ToString()));
                }
            //}

        }
    }
}