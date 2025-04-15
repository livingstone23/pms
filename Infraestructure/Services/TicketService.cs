using System.Security.Claims;
using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;
using Microsoft.AspNetCore.Http;



namespace Infraestructure.Services;



public class TicketService : ITicketService
{


    private readonly IUnitOfWork _unitOfWork;

    private readonly IHttpContextAccessor _httpContextAccesor;

    public TicketService(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccesor)
    {
        _unitOfWork = unitOfWork;
        _httpContextAccesor = httpContextAccesor;
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
            AssignedToId = result.AssignedToId,
            RaisedBy = result.User?.Id,
            RaisedByName = result.User?.Email,
            CreatedDate = result.RaisedDate,
            ExpectedDate = result.ExpectedDate,

        };

    }

    
    public List<GetTicketResponse> GetTickets(GetTicketRequest request)
    {

        // Llamada al repositorio para obtener los datos crudos
        var result = _unitOfWork.TicketRepository.GetTickets(request);

        // Convertir la lista de datos crudos a la lista de GetTicketResponse
        List<GetTicketResponse> listTickets = result.Select(x => new GetTicketResponse
        {
            TicketId = x.TicketId,
            Summary = x.Summary,
            Product = x.Product?.ProductName,
            Category = x.Category?.CategoryName,
            Priority = x.Priority?.PriorityName,
            Status = x.Status,
            RaisedBy = x.AssignedTo?.Email,
            CreatedDate = x.RaisedDate,
            ExpectedDate = x.ExpectedDate
        }).ToList();  // Convierte el resultado de Select en una lista

        return listTickets;

    }
    

    public async Task<BaseResponse> UpdateTicket(UpdateTicketRequest request)
    {

        var result = new BaseResponse();
        result.IsSuccess = false;

        var currentTicket = _unitOfWork.TicketRepository.GetByIdAsync(request.TicketId);

        if (currentTicket == null)
        {
            result.ErrorMessage = "Ticket not found!";
            return result;
        }


        currentTicket.ProductId = request.ProductId.Value;
        currentTicket.CategoryId = request.CategoryId.Value;
        currentTicket.PriorityId = request.PriorityId.Value;
        currentTicket.AssignedToId = request.AssignedToId;
        currentTicket.Status = request.Status;
        currentTicket.LastUpdateDate = DateTime.Now;

        if (request.Status == Constants.STATUS_CLOSED)
        {

            currentTicket.ClosedDate = DateTime.Now;

            var currentUser = _httpContextAccesor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Name).Value;
            
            if (currentUser == null)
            {
                result.ErrorMessage = "User is not valid, please re-login";
                return result;
            }

            currentTicket.ClosedBy = currentUser;

        }

        _unitOfWork.Repository<Ticket>().Update(currentTicket);

        var dbResult = await _unitOfWork.SaveChanges() > 0;

        if (dbResult)
        {
            result.IsSuccess = true;
        }
        else
        {
            result.ErrorMessage = "Failed when saving to database! Try again later. ";
        }

        return result;

    }


}
