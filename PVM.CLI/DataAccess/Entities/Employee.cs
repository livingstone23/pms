using System.ComponentModel.DataAnnotations;



namespace PVM.CLI.DataAccess.Entities;



public class Employee
{

    [Key]
    public int EmployeeNumber { get; set; }

    public string FullName { get; set; } = string.Empty;

    public string Department { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

    public int Age { get; set; }

    public string PhoneNumber { get; set; } = string.Empty;
    
}