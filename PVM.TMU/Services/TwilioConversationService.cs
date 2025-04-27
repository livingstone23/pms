using Twilio.Types;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Rest.Conversations.V1;



namespace PVM.TMU.Services;



public class TwilioConversationService
{
    private readonly string _accountSid;
    private readonly string _authToken;

    public TwilioConversationService(IConfiguration configuration)
    {
        _accountSid = configuration["Twilio:AccountSid"];
        _authToken = configuration["Twilio:AuthToken"];
    }

    // Crear una nueva conversación y devolver el SID
    public string CreateConversation(string conversationName)
    {
        TwilioClient.Init(_accountSid, _authToken);

        var conversation = ConversationResource.Create(
            friendlyName: conversationName
        );

        Console.WriteLine($"Created conversation: {conversation.Sid}");

        return conversation.Sid;  // Devuelve el SID de la conversación
    }

    // Enviar un mensaje dentro de la conversación
    public void SendMessage(string conversationSid, string body)
    {
        var message = MessageResource.Create(
            body: body,
            from: new PhoneNumber("+19787054784"), // Reemplazar con tu número de Twilio
            to: new PhoneNumber("+34698971985"), // Número de destino
            pathAccountSid: conversationSid
        );

        Console.WriteLine($"Message sent: {message.Sid}");
    }
}
