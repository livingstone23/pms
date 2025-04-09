using Microsoft.EntityFrameworkCore;
using PVM.CLI.DataAccess.Entities;
using PVM.CLI.Helpers;


namespace PVM.CLI.DataAccess;



public class AppDBContext: DbContext
{

    public AppDBContext(DbContextOptions options) :base(options)
    {
        
    }

    public DbSet<Employee> Employees { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);

        modelBuilder.GenerateSeed();

        //modelBuilder.Entity<Employee>()
        //    .HasKey(e => e.EmployeeNumber);
        //modelBuilder.Entity<Employee>()
        //    .Property(e => e.FullName)
        //    .IsRequired()
        //    .HasMaxLength(100);
        //modelBuilder.Entity<Employee>()
        //    .Property(e => e.Department)
        //    .IsRequired()
        //    .HasMaxLength(50);
        //modelBuilder.Entity<Employee>()
        //    .Property(e => e.DateOfBirth)
        //    .IsRequired();
        //modelBuilder.Entity<Employee>()
        //    .Property(e => e.Age)
        //    .IsRequired();
        //modelBuilder.Entity<Employee>()
        //    .Property(e => e.PhoneNumber)
        //    .IsRequired()
        //    .HasMaxLength(15);
    }

}