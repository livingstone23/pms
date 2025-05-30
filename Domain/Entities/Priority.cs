using System.ComponentModel.DataAnnotations;



namespace Domain.Entities;



public class Priority
{   
    
    [Key]
    public int PriorityId { get; set; }
    
    public string PriorityName { get; set; } = string.Empty;
    
    public int ExpectedDays { get; set; }
    
    public bool IsActive { get; set; } = true;

}
