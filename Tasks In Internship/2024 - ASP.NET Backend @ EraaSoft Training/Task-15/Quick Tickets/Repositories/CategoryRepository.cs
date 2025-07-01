using Quick_Tickets.Repositories.IRepositories;

namespace Quick_Tickets.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext dbContext) :
            base(dbContext)
        {

        }
    }
}
