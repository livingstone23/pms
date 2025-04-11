﻿using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace Infraestructure.Data;



public class AppDBContext : IdentityDbContext<User>
{
    
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
    {

    }


}