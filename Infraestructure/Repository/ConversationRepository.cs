using Domain.Entities;
using Domain.Repository;
using Infraestructure.Data;



namespace Infraestructure.Repository;



public class ConversationRepository : GenericRepository<Conversation>, IConversationRepository
{

    public ConversationRepository(AppDBContext dbContext) : base(dbContext)
    {
    }

    public Conversation GetConversation(int conversationId)
    {
        return dbContext.Set<Conversation>()
            .FirstOrDefault(x => x.Id == conversationId);
    }

    public Conversation GetConversationByConversationSid(string conversationSid)
    {
        return dbContext.Set<Conversation>()
            .FirstOrDefault(x => x.ConversationSid == conversationSid);
    }


}