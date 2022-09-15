using Microsoft.EntityFrameworkCore;
using AccountsServiceApi;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container (like the urban company).

builder.Services.AddControllers();
builder.Services.AddScoped<AccountsServiceApi.Repositories.IAccountsRepository, AccountsServiceApi.Repositories.AccountsORMRepository>();
builder.Services.AddDbContext<AccountsServiceApi.DataContexts.AccountsDBContext>(optionsbuilder =>
{
    optionsbuilder.UseSqlite(@"data source=C:\Users\X6NAVADH\Documents\accounts.db");
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
