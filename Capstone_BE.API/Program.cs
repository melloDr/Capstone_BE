using Capstone_BE.Business.Interface;
using Capstone_BE.Business.Service;
using Capstone_BE.Business.Mapper;
using Microsoft.EntityFrameworkCore;
using Capstone_BE.Data.Entities;
using AutoMapper;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<GreenGardenDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection")));

builder.Services.AddMvc();
builder.Services.AddCors();

//Mapper
builder.Services.AddSingleton(new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
}).CreateMapper());

//Service
builder.Services.AddScoped<IExampleService, ExampleService>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// Service
//builder.Services.AddScoped<IExampleService, ExampleService>();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
