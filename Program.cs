using appTurnos.Data;
using Microsoft.EntityFrameworkCore;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

// Cargar variables del .env
Env.Load();

var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION");

builder.Services.AddDbContext<TurnosContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
