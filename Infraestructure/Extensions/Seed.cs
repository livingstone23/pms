using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Extensions;

public static class Seed
{

    static string user1 = "62f94fe7-0580-42df-969c-4b0f1a2c3d7e";

    public static void GenerateSeed(this ModelBuilder modelBuilder)
    {

        string USER_EMAIL = "Test@gmail.com";

        //Create user
        var appUser = new User
        {
            Id = user1,
            Email = USER_EMAIL,
            EmailConfirmed = true,
            UserName = USER_EMAIL,
            NormalizedUserName = USER_EMAIL.ToUpper(),
            NormalizedEmail = USER_EMAIL.ToUpper(),
        };

        //set user password
        PasswordHasher<User> ph = new PasswordHasher<User>();
        appUser.PasswordHash = ph.HashPassword(appUser, "NeedReset%123");

        //Seed user
        modelBuilder.Entity<User>().HasData(appUser);

        //Seed roles
        modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = Constants.ROLE_ADMIN_ID,
                Name = Constants.ROLE_ADMIN,
                NormalizedName = Constants.ROLE_ADMIN.ToUpper()
            },
            new IdentityRole
            {
                Id = Constants.ROLE_USER_ID,
                Name = Constants.ROLE_USER,
                NormalizedName = Constants.ROLE_USER.ToUpper()
            }
        );

        //Assign Roles to Users
        modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<String>
            {
                RoleId = Constants.ROLE_ADMIN_ID,
                UserId = user1
            }
        );

        //Seed categories
        modelBuilder.Entity<Category>().HasData(
            new Category
            {
                CategoryId = 1,
                CategoryName = "Application Bug"
            },
            new Category
            {
                CategoryId = 2,
                CategoryName = "Network Issue"
            },
            new Category
            {
                CategoryId = 3,
                CategoryName = "User Issue"
            }
        );

        //Seed Products
        modelBuilder.Entity<Product>().HasData(
            new Product
            {
                ProductId = 1,
                ProductName = "Product 1"
            },
            new Product
            {
                ProductId = 2,
                ProductName = "Product 2"
            },
            new Product
            {
                ProductId = 3,
                ProductName = "Product 3"
            }
        );

        //Seed Priorities
        modelBuilder.Entity<Priority>().HasData(
            new Priority
            {
                PriorityId = 1,
                PriorityName = "Low",
                ExpectedDays = 14
            },
            new Priority
            {
                PriorityId = 2,
                PriorityName = "Medium",
                ExpectedDays = 7
            },
            new Priority
            {
                PriorityId = 3,
                PriorityName = "High",
                ExpectedDays = 1
            }
        );

        Ticket(modelBuilder);


    }


    private static void Ticket(ModelBuilder modelBuilder)
    {

        var ticktes = new[]
        {
            new Ticket { TicketId = 1, Summary = "Ticket 1", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 1", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 2, Summary = "Ticket 2", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 2", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 3, Summary = "Ticket 3", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 3", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED", ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 4, Summary = "Ticket 4", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 4", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 5, Summary = "Ticket 5", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 5", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 6, Summary = "Ticket 6", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 6", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 7, Summary = "Ticket 7", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 7", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 8, Summary = "Ticket 8", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 8", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 9, Summary = "Ticket 9", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 9", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 10, Summary = "Ticket 10", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 10", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 11, Summary = "Ticket 11", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 11", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 12, Summary = "Ticket 12", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 12", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 13, Summary = "Ticket 13", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 13", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 14, Summary = "Ticket 14", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 14", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 15, Summary = "Ticket 15", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 15", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 16, Summary = "Ticket 16", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 16", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 17, Summary = "Ticket 17", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 17", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 18, Summary = "Ticket 18", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 18", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 19, Summary = "Ticket 19", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 19", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 20, Summary = "Ticket 20", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 20", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 21, Summary = "Ticket 21", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 21", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 22, Summary = "Ticket 22", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 22", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 23, Summary = "Ticket 23", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 23", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 24, Summary = "Ticket 24", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 24", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 25, Summary = "Ticket 25", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 25", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 26, Summary = "Ticket 26", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 26", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 27, Summary = "Ticket 27", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 27", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 28, Summary = "Ticket 28", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 28", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 29, Summary = "Ticket 29", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 29", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 30, Summary = "Ticket 30", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 30", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 31, Summary = "Ticket 31", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 31", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 32, Summary = "Ticket 32", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 32", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 33, Summary = "Ticket 33", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 33", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 34, Summary = "Ticket 34", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 34", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 35, Summary = "Ticket 35", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 35", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 36, Summary = "Ticket 36", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 36", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 37, Summary = "Ticket 37", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 37", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 38, Summary = "Ticket 38", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 38", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 39, Summary = "Ticket 39", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 39", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 40, Summary = "Ticket 40", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 40", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 41, Summary = "Ticket 41", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 41", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 42, Summary = "Ticket 42", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 42", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 43, Summary = "Ticket 43", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 43", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 44, Summary = "Ticket 44", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 44", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 45, Summary = "Ticket 45", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 45", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 46, Summary = "Ticket 46", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 46", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 47, Summary = "Ticket 47", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 47", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 48, Summary = "Ticket 48", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 48", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 49, Summary = "Ticket 49", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 49", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 50, Summary = "Ticket 50", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 50", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 51, Summary = "Ticket 41", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 41", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 52, Summary = "Ticket 42", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 42", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 53, Summary = "Ticket 43", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 43", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 54, Summary = "Ticket 44", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 44", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 55, Summary = "Ticket 45", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 45", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 56, Summary = "Ticket 46", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 46", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 57, Summary = "Ticket 47", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 47", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" },
            new Ticket { TicketId = 58, Summary = "Ticket 48", ProductId = 3, CategoryId = 3, PriorityId = 3, Description = "Description 48", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(1), AssignedToId = user1, RaisedBy = user1, Status = "CLOSED" , ClosedBy = user1, ClosedDate = DateTime.Now.AddDays(1)},
            new Ticket { TicketId = 59, Summary = "Ticket 49", ProductId = 1, CategoryId = 1, PriorityId = 1, Description = "Description 49", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(7), AssignedToId = user1, RaisedBy = user1, Status = "NEW" },
            new Ticket { TicketId = 60, Summary = "Ticket 50", ProductId = 2, CategoryId = 2, PriorityId = 2, Description = "Description 50", RaisedDate = DateTime.Now, ExpectedDate = DateTime.Now.AddDays(3), AssignedToId = user1, RaisedBy = user1, Status = "OPEN" }
        };

        foreach (var ticket in ticktes )
        {
            modelBuilder.Entity<Ticket>().HasData(ticket);
        }




    }


}

