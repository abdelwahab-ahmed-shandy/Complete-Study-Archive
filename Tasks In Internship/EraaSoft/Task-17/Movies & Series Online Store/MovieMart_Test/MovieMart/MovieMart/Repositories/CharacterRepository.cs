using MovieMart.Data;
using MovieMart.Models;
using MovieMart.Repositories.IRepositories;

namespace MovieMart.Repositories
{
    public class CharacterRepository : Repository<Character>, ICharacterRepository
    {
        public CharacterRepository(MovieMartDbContext movieMartDbContext) : base(movieMartDbContext)
        {

        }
    }
}
