using BaseLibrary.Entities;
using Microsoft.EntityFrameworkCore;



namespace ServerLibrary.Data;



public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    

    public DbSet<Employee> Employees { get; set; } = null!;

    public DbSet<GeneralDeparment> GeneralDeparments { get; set; } = null!;

    public DbSet<Department> Departments { get; set; } = null!;

    public DbSet<Branch> Branches { get; set; } = null!;

    public DbSet<Town> Towns { get; set; } = null!;

    public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
    

}
