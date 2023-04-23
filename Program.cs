using System;
using Semana09.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// banco
string connectionString = "Server=DESKTOP-KRET77R;Database=Mes;Trusted_Connection=True;TrustServerCertificate=True;";
builder.Services.AddDbContext<SemanaContext>(o => o.UseSqlServer(connectionString));


builder.Services.AddDbContext<SemanaContext>();

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


/*Configurar o SemanaContext no program.cs conforme feito em aula

Criar a connection string na classe program.cs da API
Criar a Injection da conexão do EF*/