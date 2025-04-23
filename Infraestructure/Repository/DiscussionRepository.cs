using Domain.Entities;
using Domain.Repository;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;



namespace Infraestructure.Repository;



public class DiscussionRepository : GenericRepository<Discussion>, IDiscussionRepository
{

    public DiscussionRepository(AppDBContext dbContext) : base(dbContext)
    {
    }

    public List<Discussion> GetDiscussions(int ticketId)
    {
        return dbContext.Set<Discussion>()
                .Include(d => d.Attachments)
                .Include(d => d.User)
                .Where(d => d.TicketId == ticketId)
                .OrderBy(d => d.CreatedDate)
                .ToList();
    }

}