using MovieMart.Data;
using MovieMart.Models;
using MovieMart.Repositories.IRepositories;

namespace MovieMart.Repositories
{
    public class EpisodeRepository : Repository<Episode>, IEpisodeRepository
    {
        public EpisodeRepository(MovieMartDbContext movieMartDbContext) : base(movieMartDbContext)
        {

        }
    }
}
