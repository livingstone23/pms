using Domain.Entities;
using Infraestructure.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace Infraestructure.Data;



public class AppDBContext : IdentityDbContext<User>
{
    
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {

    }


    public DbSet<Ticket> Tickets { get; set; } = null!;
    
    public DbSet<Product> Products { get; set; } = null!;
    
    public DbSet<Priority> Priorities { get; set; } = null!;

    public DbSet<Discussion> Discussions { get; set; } = null!;

    public DbSet<Category> Categories { get; set; } = null!;
    
    public DbSet<Attachment> Attachments { get; set; } = null!;



    protected override void OnModelCreating(ModelBuilder builder)
    {
        
        base.OnModelCreating(builder);

        builder.GenerateSeed();

        //builder.Entity<Ticket>()
        //    .HasOne(t => t.User)
        //    .WithMany()
        //    .OnDelete(DeleteBehavior.NoAction);

        builder.Entity<Discussion>()
            .HasOne(t => t.Ticket)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);    

        

    }


}