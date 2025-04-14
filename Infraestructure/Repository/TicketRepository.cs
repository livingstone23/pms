using Azure.Core;
using Domain.DTO.Request;
using Domain.Entities;
using Domain.Repository;
using Infraestructure.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace Infraestructure.Repository;



public class TicketRepository : GenericRepository<Ticket>, ITicketRepository
{
    
    public TicketRepository(AppDBContext dbContext) : base(dbContext)
    {

    }


    public List<Ticket> GetTickets(GetTicketRequest request)
    {

        IQueryable<Ticket> query = dbContext.Set<Ticket>()
                                    .Include(t => t.Category)
                                    .Include(t => t.Priority)
                                    .Include(t => t.Product)
                                    .Include(t => t.User)
                                    .Include(t => t.AssignedTo);
        

        if (request == null) return query.ToList();
        
        if(!string.IsNullOrEmpty(request.Summary))
        {
            query = query.Where(x => (EF.Functions.Like(x.Summary, $"%{request.Summary}%")));
        }

        if(request.ProductId != null && request.ProductId.Count() > 0)
        {
            query = query.Where(x => request.ProductId.Contains(x.ProductId));
        }

        if(request.PriorityId != null && request.PriorityId.Count() > 0)
        {
            query = query.Where(x => request.PriorityId.Contains(x.PriorityId));
        }

        if(request.CategoryId != null && request.CategoryId.Count() > 0)
        {
            query = query.Where(x => request.CategoryId.Contains(x.CategoryId));
        }

        if(request.Status != null && request.Status.Count() > 0)
        {
            query = query.Where(x => request.Status.Contains(x.Status));
        }

        if(request.RaisedBy != null && request.RaisedBy.Count() > 0)
        {
            query = query.Where(x => request.RaisedBy.Contains(x.RaisedBy));
        }
       
        return query.OrderByDescending(x => x.RaisedDate).ToList();

    }



}
