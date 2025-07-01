using MovieMart.Data;
using MovieMart.Models;
using MovieMart.Repositories.IRepositories;

namespace MovieMart.Repositories
{
    public class SeasonRepository : Repository<Season>, ISeasonRepository
    {
        public SeasonRepository(MovieMartDbContext movieMartDbContext) : base(movieMartDbContext)
        {

        }
    }
}
