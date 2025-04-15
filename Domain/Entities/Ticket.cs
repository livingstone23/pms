using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Domain.Entities;



public class Ticket
{

    public Ticket()
    {
        Attachments = new HashSet<Attachment>();
    }

    
    [Key]
    public int TicketId { get; set; }
    
    public string Summary { get; set; } = string.Empty;

    public string? Description { get; set; } = string.Empty;
    
    public DateTime RaisedDate { get; set; }
    
    public DateTime ExpectedDate { get; set; }


    [ForeignKey(nameof(AssignedToId))]
    public string AssignedToId { get; set; } = string.Empty;
    public User? AssignedTo { get; set; }


    [ForeignKey(nameof(RaisedBy))]
    public string RaisedBy { get; set; } = string.Empty;
    public User? User { get; set; }


    [ForeignKey(nameof(ProductId))]
    public int ProductId { get; set; }
    public Product Product { get; set; }


    [ForeignKey(nameof(CategoryId))]
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;


    [ForeignKey(nameof(PriorityId))]
    public int PriorityId { get; set; }
    public Priority Priority { get; set; } = null!;


    public string Status { get; set; }


    public string? ClosedBy { get; set; }
    
    public DateTime? ClosedDate { get; set; }
    
    public DateTime? LastUpdateDate { get; set; }


    public virtual ICollection<Attachment> Attachments { get; set; } = null!;


}
