using DataAccess.Services;
using DataAccess.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

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