using Microsoft.EntityFrameworkCore;
using Ejercicio1.DAL;


var builder = WebApplication.CreateBuilder(args);

//2. Connection with SQL Server
const string CONNECTIONNAME = "Ejercicio1DB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

//3. Add Context to services of builder
builder.Services.AddDbContext<Ejercicio1Context>(options => options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
