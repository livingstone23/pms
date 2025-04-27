using Domain.DTO.Request;
using Domain.DTO.Response;



namespace Domain.Interfaces;



public interface IConversationService
{

    List<ConversationResponse> GetConversations();

    ConversationResponse GetConversation(int conversionId);

    ConversationResponse GetConversationByConversationSid(string ConversationSid);

    Task<BaseResponse> UpdateConversation(UpdateConversationRequest request);

    Task<BaseResponse<int>> CreateConversation(CreateConversationRequest request);

}