using Microsoft.EntityFrameworkCore;
using SoundBox.Infrastructure.Persistence.DataModel;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ChinookDbContext>(options =>
{
    options.UseSqlite("Data Source=chinook.sqlite");
});
var app = builder.Build();

app.MapGet("/api/test", (ChinookDbContext db) =>
{
    return Results.Ok(db.Employees.Select(e => new { e.FirstName,e.LastName }));
});

app.MapGet("/", () => "Hello World!"); // Minimal API

app.Run();
