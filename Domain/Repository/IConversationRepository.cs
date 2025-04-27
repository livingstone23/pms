using Domain.Entities;



namespace Domain.Repository;



public interface IConversationRepository : IGenericRepository<Conversation>
{
    Conversation GetConversation(int conversationId);

    Conversation GetConversationByConversationSid(string conversationSid);

}