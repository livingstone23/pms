using Microsoft.EntityFrameworkCore;
using PVM.CLI.DataAccess;
using PVM.CLI.DataAccess.Entities;
using PVM.CLI.ViewModels;

namespace PVM.CLI.Services;

public class EmployeeService
{
    private readonly AppDBContext _context;

    public EmployeeService(AppDBContext context)
    {
        _context = context;
    }

    public async Task<List<EmployeeViewModel>> GetAllEmployeesAsync()
    {
        return await _context.Employees
            .OrderBy(x=> x.FullName)
            .Select(x => new EmployeeViewModel
            {
                EmployeeNumber = x.EmployeeNumber,
                FullName = x.FullName,
                Department = x.Department,
                DateOfBirth = x.DateOfBirth,
                Age = x.Age,
                PhoneNumber = x.PhoneNumber
            }).ToListAsync();
    }
}