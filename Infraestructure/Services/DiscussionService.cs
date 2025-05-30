using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;
using Infraestructure.Repository;
using Microsoft.AspNetCore.Hosting;



namespace Infraestructure.Services;



public class DiscussionService : IDiscussionService
{

    private readonly IUnitOfWork _unitOfWork;
    private readonly IAccountService _accountService;
    private readonly IWebHostEnvironment _webHostEnvironment;
    private readonly IDiscussionRepository _discussionRepository;
    public DiscussionService(IUnitOfWork unitOfWork,
                            IAccountService accountService,
                            IWebHostEnvironment webHostEnvironment, 
                            IDiscussionRepository discussionRepository)
    {
        _unitOfWork = unitOfWork;
        _accountService = accountService;
        _webHostEnvironment = webHostEnvironment;
        _discussionRepository = discussionRepository;
    }

   


    public async Task<BaseResponse> Create(CreateDiscussionRequest request)
    {
        
        BaseResponse response = new BaseResponse();
        response.IsSuccess = false;
        var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads","attachments");

        var currentUser = await _accountService.GetCurrentUser();

        if (!currentUser.IsSuccess)
        {
            response.ErrorMessage = currentUser.ErrorMessage;
            return response;
        }

        Discussion discussion = new Discussion
        {
            CreatedDate = DateTime.Now,
            Message = request.Message,
            TicketId = request.TicketId,
            UserId = currentUser.Value.Id,
            
        };

        _unitOfWork.DiscussionRepository.Add(discussion);

        //Saving the attachments
        if (request.Attachments != null && request.Attachments.Count > 0)
        {

            foreach (var file in request.Attachments)
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
                    Discussion = discussion,
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
            response.IsSuccess = true;
            return response;
        }
        else
        {
            response.ErrorMessage = "Failed when create discussion! ";
            return response;
        }

    }

    public List<DiscussionResponse> GetDiscusions(int ticketId)
    {
        var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", "attachments");

        var result = _discussionRepository.GetDiscussions(ticketId);

        return result.Select(x => new DiscussionResponse 
        {
            Message = x.Message,
            CreatedDate = x.CreatedDate,
            User = x.User,
            Attachments = x.Attachments.Select(x => new AttachmentResponse
            {
                FileName = x.FileName,
                ServerFileName = Path.Combine(uploadPath, x.ServerFileName),
            }).ToList(),
        }).ToList();



    }



}
