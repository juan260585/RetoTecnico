using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Medicamentos_API.EntityFramework.DB>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Medicamentos_APIDBContext") ?? throw new InvalidOperationException("Connection string 'Medicamentos_APIDBContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddCors();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors(x => x.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod());

app.UseAuthorization();

app.MapControllers();

app.Run();
