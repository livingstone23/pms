using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;


namespace Domain.DTO.Request;



public class CreateTicketRequest
{

    [Required]
    public string Summary { get; set; }

    public string? Description { get; set; }

    [Required]
    public int? ProductId { get; set; }

    [Required]
    public int? CategoryId { get; set; }

    [Required]
    public int? PriorityId { get; set; }

    [Required]
    public string AssignedToId { get; set; }


    public string? RaisedBy { get; set; }


    public IList<IBrowserFile> files;


}
