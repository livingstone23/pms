using System.Security.Claims;
using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;



namespace Infraestructure.Services;



public class TicketService : ITicketService
{


    private readonly IUnitOfWork _unitOfWork;

    private readonly IHttpContextAccessor _httpContextAccesor;

    private readonly IWebHostEnvironment _webHostEnvironment;

    public TicketService(   IUnitOfWork unitOfWork,
                            IHttpContextAccessor httpContextAccesor,
                            IWebHostEnvironment webHostEnvironment)
    {
        _unitOfWork = unitOfWork;
        _httpContextAccesor = httpContextAccesor;
        _webHostEnvironment = webHostEnvironment;
    }

    public GetTicketResponse FindTicket(int ticketId)
    {

        //var result = _unitOfWork.Repository<Ticket>().GetByIdAsync(ticketId);
        var result = _unitOfWork.TicketRepository.FindTicket(ticketId);
        if (result == null) return null;

        //var attachments = _unitOfWork.Repository<Attachment>().ListAll().Where(x => x.TicketId == result.TicketId);
        var attachmentpath = Path.Combine("uploads", "attachments");

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
            RaisedByAvatar = result.User?.Avatar,
            CreatedDate = result.RaisedDate,
            ExpectedDate = result.ExpectedDate,
            ClosedBy = result.ClosedBy,
            ClosedDate = result.ClosedDate,
            Attachments = result.Attachments.Select(x => new AttachmentResponse
            {
                FileName = x.FileName,
                ServerFileName = Path.Combine(attachmentpath, x.ServerFileName),
            }).ToList()
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

            var currentUser = _httpContextAccesor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;

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


    public async Task<BaseResponse<int>> CreateTicket(CreateTicketRequest request)
    {

        var createTicketResult = new BaseResponse<int>() { IsSuccess = false };
        var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", "attachments");

        try
        {

            var use = _httpContextAccesor.HttpContext.User.Claims;

            var currentUser = _httpContextAccesor.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value;
            if (currentUser == null)
            {
                createTicketResult.ErrorMessage = "User is not valid, please re-login";
                return createTicketResult;
            }

            Ticket ticket = new Ticket();
            ticket.Summary = request.Summary;
            ticket.Description = request.Description;
            ticket.ProductId = request.ProductId.Value;
            ticket.CategoryId = request.CategoryId.Value;
            ticket.PriorityId = request.PriorityId.Value;

            //Corregir en la mejora
            ticket.AssignedToId = request.AssignedToId;

            ticket.RaisedBy = currentUser;
            ticket.RaisedDate = DateTime.Now;
            ticket.Status = Constants.STATUS_NEW;

            var priority = _unitOfWork.Repository<Priority>().GetByIdAsync(request.PriorityId.Value);
            if (priority != null)
            {
                ticket.ExpectedDate = DateTime.Now.AddDays(priority.ExpectedDays);
            }

            _unitOfWork.Repository<Ticket>().Add(ticket);


            //Saving the attachments
            if (request.files != null && request.files.Count > 0)
            {

                foreach (var file in request.files)
                {
                    var fileExt = Path.GetExtension(file.Name);
                    var actualName = Path.GetFileNameWithoutExtension(file.Name);
                    var fileName = $"{actualName}-{Guid.NewGuid().ToString()}{fileExt}";
                    var filePath = Path.Combine(uploadPath, fileName);

                    using (var filestream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.OpenReadStream().CopyToAsync(filestream);
                    }

                    Attachment attachment = new Attachment
                    {
                        Ticket = ticket,
                        FileName = Path.GetFileName(file.Name),
                        ServerFileName = fileName,
                        FileSize = file.Size,
                        CreatedDate = DateTime.Now,
                    };
                    _unitOfWork.Repository<Attachment>().Add(attachment);
                }
            }

            var result = await _unitOfWork.SaveChanges() > 0;

            if (result)
            {
                createTicketResult.IsSuccess = true;
                createTicketResult.Value = ticket.TicketId;
                return createTicketResult;
            }
            else
            {
                createTicketResult.ErrorMessage = "Failed when create ticket! ";
                return createTicketResult;
            }

        }
        catch (Exception ex)
        {
            createTicketResult.ErrorMessage = "Failed: " + ex.Message;
            return createTicketResult;
        }

    }

    public List<ChartResponse> Last12MonthTickets()
    {
        return _unitOfWork.TicketRepository.Last12MonthTickets();
    }

    public List<ChartResponse> ChartByCategory(string category)
    {
        return _unitOfWork.TicketRepository.ChartByCategory(category);
    }

    public List<ChartResponse> GetSummary()
    {
        return _unitOfWork.TicketRepository.GetSummary();
    }


}
