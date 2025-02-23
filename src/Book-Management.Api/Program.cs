using Book_Management.Api.Middlewares;
using Book_Management.Infrastructure;
using Book_Managment.Application;
using Book_Managment.Application.UseCases.Books.Commands.Add;
using Book_Managment.Application.UseCases.Books.Commands.Delete;
using Book_Managment.Application.UseCases.Books.Commands.Update;
using MediatR;
using System.Reflection;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);

//builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

builder.Services.AddControllers();
builder.Services.AddApplication();


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

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.MapControllers();

app.Run();
