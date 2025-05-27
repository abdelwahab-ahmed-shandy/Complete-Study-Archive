using MovieMart.Data;
using MovieMart.Models;
using MovieMart.Repositories.IRepositories;

namespace MovieMart.Repositories
{
    public class TvSeriesRepository : Repository<TvSeries>, ITvSeriesRepository
    {
        public TvSeriesRepository(MovieMartDbContext movieMartDbContext) : base(movieMartDbContext)
        {

        }
    }
}
