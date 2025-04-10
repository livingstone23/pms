using ClosedXML.Excel;
using EFCore.BulkExtensions;
using Microsoft.EntityFrameworkCore;
using PVM.CLI.DataAccess;
using PVM.CLI.DataAccess.Entities;
using PVM.CLI.ViewModels;
using Exception = System.Exception;



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


    public bool CreateNewEmployee(EmployeeViewModel mode)
    {

        try
        {

            Employee employee = new Employee
            {
                EmployeeNumber = mode.EmployeeNumber,
                FullName = mode.FullName,
                Department = mode.Department,
                DateOfBirth = mode.DateOfBirth,
                Age = mode.Age,
                PhoneNumber = mode.PhoneNumber
            };

            _context.Employees.Add(employee);

            var result = _context.SaveChanges();

            return result > 0;

        }
        catch (Exception e)
        {
            return false;
        }
    }


    public EmployeeViewModel? FindEmployee(int employeeNumber)
    {
        var employee = _context.Employees.Find(employeeNumber);
        if (employee == null) return null;

        EmployeeViewModel result = new EmployeeViewModel
        {
            EmployeeNumber = employee.EmployeeNumber,
            FullName = employee.FullName,
            Department = employee.Department,
            DateOfBirth = employee.DateOfBirth,
            Age = employee.Age,
            PhoneNumber = employee.PhoneNumber
        };

        return result;

    }

    public bool UpdateEmployee(EmployeeViewModel model)
    {
        try
        {
            var employee = _context.Employees.Find(model.EmployeeNumber);

            if (employee == null) return false;
            
            employee.FullName = model.FullName;
            employee.Department = model.Department;
            employee.DateOfBirth = model.DateOfBirth;
            employee.Age = model.Age;
            employee.PhoneNumber = model.PhoneNumber;
            var result = _context.SaveChanges();
            return result > 0;
        }
        catch (Exception e)
        {
            return false;
        }
    }


    public bool DeleteEmployee(int employeeNumber)
    {
        try
        {
            var employee = _context.Employees.Find(employeeNumber);
            if (employee == null) return false;

            _context.Employees.Remove(employee);
            var result = _context.SaveChanges();
            return result > 0;
        }
        catch (Exception e)
        {
            return false;
        }
    }



    public async Task<bool> ImportEmployee(List<EmployeeViewModel> employees)
    {

        try
        {

            List<Employee> toDB = new List<Employee>();

            foreach (var employee in employees)
            {
                Employee emp = new Employee
                {
                    EmployeeNumber = employee.EmployeeNumber,
                    FullName = employee.FullName,
                    Department = employee.Department,
                    DateOfBirth = employee.DateOfBirth,
                    Age = employee.Age,
                    PhoneNumber = employee.PhoneNumber
                };
                toDB.Add(emp);
            }

            await _context.BulkInsertAsync(toDB);

            return true;

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }

    }



    public async Task<Byte[]> ExporttoExcel()
    {

        var data = await GetAllEmployeesAsync();

        using (var workbook = new XLWorkbook())
        {

            var worksheet = workbook.Worksheets.Add("Employees");
            worksheet.Cell(1, 1).Value = "Employee Number";
            worksheet.Cell(1, 2).Value = "Full Name";
            worksheet.Cell(1, 3).Value = "Department";
            worksheet.Cell(1, 4).Value = "Date Of Birth";
            worksheet.Cell(1, 5).Value = "Age";
            worksheet.Cell(1, 6).Value = "Phone Number";
            for (int i = 0; i < data.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = data[i].EmployeeNumber;
                worksheet.Cell(i + 2, 2).Value = data[i].FullName;
                worksheet.Cell(i + 2, 3).Value = data[i].Department;
                worksheet.Cell(i + 2, 4).Value = data[i].DateOfBirth;
                worksheet.Cell(i + 2, 5).Value = data[i].Age;
                worksheet.Cell(i + 2, 6).Value = data[i].PhoneNumber;
            }
            using (var stream = new MemoryStream())
            {
                workbook.SaveAs(stream);
                return stream.ToArray();
            }

        }

    }



    public async Task<bool> ExportEmployee(string filePath)
    {
        try
        {
            var employees = await _context.Employees.ToListAsync();
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var employee in employees)
                {
                    await writer.WriteLineAsync($"{employee.EmployeeNumber},{employee.FullName},{employee.Department},{employee.DateOfBirth},{employee.Age},{employee.PhoneNumber}");
                }
            }
            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }



}