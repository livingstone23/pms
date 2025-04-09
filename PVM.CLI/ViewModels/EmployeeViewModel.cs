using System.ComponentModel.DataAnnotations;

namespace PVM.CLI.ViewModels;

public class EmployeeViewModel
{

    [Required]
    public int EmployeeNumber { get; set; }

    public string EmployeeNumberView
    {
        get
        {
            return "EMP" + EmployeeNumber.ToString().PadLeft(4,'0');
        }
    }

    [Required]
    public string FullName { get; set; }

    [Required]
    public string Department { get; set; } 

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    public int Age { get; set; }

    [Required]
    public string PhoneNumber { get; set; } 

}