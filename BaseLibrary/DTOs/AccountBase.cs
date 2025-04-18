using System.ComponentModel.DataAnnotations;



namespace BaseLibrary.DTOs;



public class AccountBase
{
        
    [DataType(DataType.EmailAddress)]
    [EmailAddress]
    public string? Email { get; set; }


    [DataType(DataType.Password)]
    [Required]
    public string? Password { get; set; }

}
