using Azure.Core;
using Domain.DTO.Request;
using Domain.DTO.Response;
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
                                    .Include(t => t.AssignedTo)
                                ;
        

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

    public List<ChartResponse> Last12MonthTickets()
    {

        var startMonth = DateTime.Now.AddMonths(-11);

        var query = dbContext.Set<Ticket>()
                        .Where(x => x.RaisedDate >= startMonth)
                        .GroupBy(x => new { x.RaisedDate.Year, x.RaisedDate.Month })
                        .Select(g => new 
                        {
                            g.Key.Month,
                            g.Key.Year,
                            Count = g.Count(),
                        })
                        .OrderBy(x => x.Year)
                        .ThenBy(x => x.Month)
                        .ToList();

        return query.Select(x => new ChartResponse
        {
            Label = new DateTime(x.Year, x.Month,1).ToString("MMM yyyy"),
            Value = x.Count
        }).ToList();



    }

    public List<ChartResponse> ChartByCategory(string category)
    {
        IQueryable<IGrouping<string, Ticket>> data;

        category = category.ToLower();
        switch (category)
        {
            case "category":
                data = dbContext.Set<Ticket>().Include(x => x.Category).GroupBy(x => x.Category.CategoryName);
                break;

            case "product":
                data = dbContext.Set<Ticket>().Include(x => x.Product).GroupBy(x => x.Product.ProductName);
                break;

            case "priority":
                data = dbContext.Set<Ticket>().Include(x => x.Priority).GroupBy(x => x.Priority.PriorityName);
                break;

            default:
                return null;

        }

        return data.Select(x => new ChartResponse
        {
            Label = x.Key,
            Value = x.Count()
        }).ToList();



    }

    public List<ChartResponse> GetSummary()
    {
        
        return dbContext.Set<Ticket>()
                        .GroupBy(x => x.Status)
                        .Select(x => new ChartResponse
                        {
                            Label = x.Key,
                            Value = x.Count()
                        }).ToList();

    }



}
