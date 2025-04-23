using Domain.Entities;
using Domain.Interfaces;
using Domain.Repository;
using Infraestructure.Data;
using Infraestructure.Repository;
using Infraestructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using PVM.TMU.Components;
using PVM.TMU.Security;


var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddCircuitOptions(options => options.DetailedErrors = true);  // Habilitar errores detallados


//Enable Authorization and Authentication
builder.Services.AddAuthorization();
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddAuthentication().AddCookie(IdentityConstants.ApplicationScheme);


builder.Services.AddIdentityCore<User>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<AppDBContext>()
    .AddSignInManager();

builder.Services.ConfigureApplicationCookie(opt => {
    opt.LoginPath = "/login";
    opt.AccessDeniedPath = "/accessdenied";
});    


builder.Services.AddDbContext<AppDBContext>(opt=>{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


//Enable Services
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ICriteriaService, CriteriaServices>();
builder.Services.AddScoped<ITicketService, TicketService>();
builder.Services.AddScoped<IDiscussionService, DiscussionService>();


builder.Services.AddScoped(typeof(EncryptionHelper<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ITicketRepository, TicketRepository>();
builder.Services.AddScoped<IDiscussionRepository, DiscussionRepository>();


builder.Services.AddMudServices();
builder.Services.AddHttpContextAccessor();



var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();


app.UseAuthentication();
app.UseAuthorization();


app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
