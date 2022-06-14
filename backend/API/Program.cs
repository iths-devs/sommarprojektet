using DataAccess.Services;
using DataAccess.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var configuration = builder.Configuration;
// Add services to the container.

services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddCors();

services.AddSingleton<ITemplateRepositoryService, TemplateRepositoryService>();

services.AddAuthentication().AddMicrosoftAccount(microsoftOptions =>
    {
        microsoftOptions.ClientId = configuration["Authentication:Microsoft:ClientId"];
        microsoftOptions.ClientSecret = configuration["Authentication:Microsoft:ClientSecret"];
    });
builder.Services.AddScoped<ITemplateRepositoryService, TemplateRepositoryService>();

builder.Services.AddDbContext<TemplateDbContext>(options => options.UseInMemoryDatabase("TemplateImdb"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(a => a.AllowAnyOrigin());
}
else
{
#warning Setup CORS
    //TODO: Set up Cors policy
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();