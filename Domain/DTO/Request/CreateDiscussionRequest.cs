using Microsoft.AspNetCore.Components.Forms;



namespace Domain.DTO.Request;



public class CreateDiscussionRequest
{
    
    public string Message { get; set; }
    public int TicketId { get; set; }
    public List<IBrowserFile> Attachments { get; set; }
    
}