using Quick_Tickets.Repositories.IRepositories;

namespace Quick_Tickets.Repositories
{
    public class ActorRepository : Repository<Actor>, IActorRepository
    {
        public ActorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
