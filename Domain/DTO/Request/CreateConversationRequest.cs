namespace Domain.DTO.Request;



public class CreateConversationRequest
{
    public string UserPhone { get; set; }  // Teléfono del usuario que crea la consulta

    public string Description { get; set; }  // Descripción del problema o solicitud

    public string State { get; set; }  // Estado de la consulta: "Open", "en InProcess", "Close"

    public DateTime DateCreation { get; set; }  // Fecha de creación de la consulta

    public DateTime? DateUpdated { get; set; }  // Fecha de actualización de la consulta

    public string ConversationSid { get; set; }

}