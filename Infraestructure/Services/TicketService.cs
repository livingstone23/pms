using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;



namespace Infraestructure.Services;



public class TicketService : ITicketService
{


    private readonly IUnitOfWork _unitOfWork;

    public TicketService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public GetTicketResponse FindTicket(int ticketId)
    {
        
        var result = _unitOfWork.Repository<Ticket>().GetByIdAsync(ticketId);
        if (result == null) return null;

        return new GetTicketResponse
        {

            TicketId = result.TicketId,
            Summary = result.Summary,
            Description = result.Description,
            ProductId = result.ProductId,
            PriorityId = result.PriorityId,
            CategoryId = result.CategoryId,
            Status = result.Status,
            RaisedBy = result.User?.Email,
            CreatedDate = result.RaisedDate,
            ExpectedDate = result.ExpectedDate,

        };

    }



    public List<GetTicketResponse> GetTickets(GetTicketRequest request)
    {
        
        var result = _unitOfWork.TicketRepository.GetTickets(request);

        return result.Select(x => new GetTicketResponse {
            TicketId = x.TicketId,
            Summary = x.Summary,
            Product = x.Product?.ProductName,
            Category = x.Category?.CategoryName,
            Priority = x.Priority?.PriorityName,
            Status = x.Status,
            RaisedBy = x.User?.Email,
            CreatedDate = x.RaisedDate,
            ExpectedDate = x.ExpectedDate

        }).ToList();

    }


}
