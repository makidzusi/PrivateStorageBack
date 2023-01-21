using BusinessLogic.Services;
using Microsoft.EntityFrameworkCore;
using PrivateStorage.Core.Services;
using PrivateStorage.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PrivateCloudContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PrivateCloudContext"));
});

builder.Services.AddTransient<IFileService, FileService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
