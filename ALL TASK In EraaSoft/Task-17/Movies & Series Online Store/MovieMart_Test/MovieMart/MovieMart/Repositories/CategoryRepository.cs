using MovieMart.Data;
using MovieMart.Models;
using MovieMart.Repositories.IRepositories;

namespace MovieMart.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(MovieMartDbContext movieMartDbContext)
            : base(movieMartDbContext)
        {

        }
    }
}
