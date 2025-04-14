using System.ComponentModel.DataAnnotations;



namespace Domain.Entities;



public class Product
{

    
    [Key]
    public int ProductId { get; set; }
    
    [Required]
    public string ProductName { get; set; }

}
