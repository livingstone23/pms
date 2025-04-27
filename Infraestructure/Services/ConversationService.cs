using Domain.DTO.Request;
using Domain.DTO.Response;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;



namespace Infraestructure.Services;



public class ConversationService : IConversationService
{

    private readonly IUnitOfWork _unitOfWork;

    public ConversationService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public List<ConversationResponse> GetConversations()
    {

        var result = _unitOfWork.Repository<Conversation>().ListAll();

        return result.Select(x => new ConversationResponse
        {
            Id = x.Id,
            UserPhone = x.UserPhone,
            Description = x.Description,
            State = x.State,
            DateCreation = x.DateCreation,
            DateUpdated = x.DateUpdated,
            ConversationSid = x.ConversationSid
        }).ToList();

    }


    public ConversationResponse GetConversation(int conversionId)
    {

        var result = _unitOfWork.ConversationRepository.GetConversation(conversionId);

        if (result == null) return null;

        return new ConversationResponse
        {
            Id = result.Id,
            UserPhone = result.UserPhone,
            Description = result.Description,
            State = result.State,
            DateCreation = result.DateCreation,
            DateUpdated = result.DateUpdated,
            ConversationSid = result.ConversationSid
        };

    }


    public ConversationResponse GetConversationByConversationSid(string ConversationSid)
    {

        var result = _unitOfWork.ConversationRepository.GetConversationByConversationSid(ConversationSid);

        if (result == null) return null;

        return new ConversationResponse
        {
            Id = result.Id,
            UserPhone = result.UserPhone,
            Description = result.Description,
            State = result.State,
            DateCreation = result.DateCreation,
            DateUpdated = result.DateUpdated,
            ConversationSid = result.ConversationSid
        };

    }


    public async Task<BaseResponse<int>> CreateConversation(CreateConversationRequest request)
    {

        var createConversationResult = new BaseResponse<int>() { IsSuccess = false };

        try
        {
            Conversation newConversation = new Conversation
            {
                UserPhone = request.UserPhone,
                Description = request.Description,
                State = request.State,
                DateCreation = DateTime.Now,
                ConversationSid = request.ConversationSid
            };

            _unitOfWork.Repository<Conversation>().Add(newConversation);

            var result = await _unitOfWork.SaveChanges() > 0;

            if (result)
            {
                createConversationResult.IsSuccess = true;
                createConversationResult.Value = newConversation.Id;
                return createConversationResult;
            }
            else
            {
                createConversationResult.ErrorMessage = "Failed when create ticket! ";
                return createConversationResult;
            }
        }
        catch (Exception ex)
        {
            createConversationResult.ErrorMessage = "Failed: " + ex.Message;
            return createConversationResult;
        }
    }


    public async Task<BaseResponse> UpdateConversation(UpdateConversationRequest request)
    {

        var result = new BaseResponse();
        result.IsSuccess = false;

        var currentConversation = _unitOfWork.ConversationRepository.GetByIdAsync(request.Id);

        if (currentConversation == null)
        {
            result.ErrorMessage = "Conversation not found!";
            return result;
        }

        currentConversation.UserPhone = request.UserPhone;
        currentConversation.Description = request.Description;
        currentConversation.State = request.State;
        currentConversation.DateCreation = request.DateCreation;
        currentConversation.DateUpdated = DateTime.Now;
        currentConversation.ConversationSid = request.ConversationSid;

        _unitOfWork.Repository<Conversation>().Update(currentConversation);

        var updateResult = await _unitOfWork.SaveChanges() > 0;

        if (updateResult)
        {
            result.IsSuccess = true;
            return result;
        }
        else
        {
            result.ErrorMessage = "Failed when update conversation!";
            return result;
        }

    }


}