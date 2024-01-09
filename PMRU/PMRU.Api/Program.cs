using PMRU.Persistence;
using PMRU.Application;
using PMRU.Infrastructure;
using PMRU.Mapper;
using PMRU.Application.Exceptions;
using System.Reflection;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PMRU.Application.Features.Doctors.Command.DeleteDoctor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var env = builder.Environment;

builder.Configuration
    .SetBasePath(env.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: false)
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);

builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddCustomMapper();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
//builder.Services.AddCommandHandler<DeleteDoctorCommandRequest, DeleteDoctorCommandResponse>(new DeleteDoctorCommandHandler());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionHandlingMiddleware();
app.UseAuthorization();

app.MapControllers();

app.Run();

public class DeleteDoctorCommandResponse
{
}