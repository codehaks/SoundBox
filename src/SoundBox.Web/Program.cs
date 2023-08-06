using Microsoft.EntityFrameworkCore;
using SoundBox.Application.Contracts;
using SoundBox.Application.Services;
using SoundBox.Infrastructure.Persistence.DataModel;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IArtistService, ArtistService>();

builder.Services.AddDbContext<ChinookDbContext>(options =>
{
    options.UseSqlite("Data Source=chinook.sqlite");
});
var app = builder.Build();

app.MapControllers();
app.Run();
