using System.ComponentModel.DataAnnotations;



namespace Domain.DTO.Request;



public class ChangePasswordRequest
{

    [Required]
    public string CurrentPassword { get; set; }

    [Required]
    public string NewPassword { get; set; }

    [Required]
    [Compare("newPassword", ErrorMessage = "Passwords do not match.")]
    public string ConfirmNewPassword { get; set; }

}
