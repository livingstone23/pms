namespace Domain.DTO.Request;



public class GetTicketRequest
{

    public string? Summary { get; set; }

    public int[]? ProductId { get; set; } = Array.Empty<int>();

    public int[]? CategoryId { get; set; } = Array.Empty<int>();

    public int[]? PriorityId { get; set; } = Array.Empty<int>();

    public string[]? Status { get; set; } = Array.Empty<string>();

    public string[]? RaisedBy { get; set; } = Array.Empty<string>();

}
