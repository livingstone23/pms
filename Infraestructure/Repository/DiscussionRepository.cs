using Domain.Entities;
using Domain.Repository;
using Infraestructure.Data;



namespace Infraestructure.Repository;



public class DiscussionRepository : GenericRepository<Discussion>, IDiscussionRepository
{
    public DiscussionRepository(AppDBContext dbContext) : base(dbContext)
    {
    }

    public List<Discussion> GetDiscussions(int ticketId)
    {
        throw new NotImplementedException();
    }
}